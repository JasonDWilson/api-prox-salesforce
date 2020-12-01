using Jwpro.Api.Proxy.Configuration;
using Jwpro.Api.Proxy.DTOs;
using Newtonsoft.Json;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Jwpro.Api.Proxy
{
    public class DataManager
    {
        private SalesForceConfiguration _config;
        private string _token;

        public DataManager(SalesForceConfiguration config = null)
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));
            authenticate();
        }

        private void authenticate()
        {
            try
            {
                string postbody = $"grant_type=password&client_id={_config.Key}&client_secret={_config.Secret}&username={_config.Username}&password={_config.Password}{_config.AccountToken}";
                _token = _config.AuthorizationUrl.PostToUrl(postbody).FromJson<SalesForceAuthenticationResponse>()
                    .access_token;
            } catch(Exception ex)
            {
                throw new AuthenticationException("Error authenticating to Salesforce", ex);
            }
        }

        private string getAccountBaseQuery()
        {
            StringBuilder query = new StringBuilder($"{_config.ApiUrl}query?q=SELECT");
            PropertyInfo[] accountProperties = typeof(Account).GetProperties();
            int count = 0;
            foreach(PropertyInfo property in accountProperties)
            {
                if(property.Name.ToLower() != "attributes")
                {
                    if(count > 0)
                        query.Append(",");
                    if(property.Name.ToLower() != "owner")
                        query.Append($"+{property.Name}");
                    else
                    {
                        PropertyInfo[] userProperties = typeof(User).GetProperties();
                        int userCount = 0;
                        foreach(PropertyInfo userProperty in userProperties)
                        {
                            if(userProperty.Name.ToLower() != "attributes")
                            {
                                if(userCount > 0)
                                    query.Append(",");

                                query.Append($"+owner.{userProperty.Name}");
                                userCount++;
                            }
                        }
                    }
                    count++;
                }
            }
            query.Append("+FROM+Account");
            return query.ToString();
        }

        private SalesForceConfiguration getDefaultConfig()
        {
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return JsonConvert.DeserializeObject<SalesForceConfiguration>(
                File.ReadAllText($@"{path}\salesForceConfig.json"));
        }

        public string AddTask(Task task)
        {
            if(string.IsNullOrEmpty(_token))
                authenticate();

            try
            {
                string url = $"{_config.ApiUrl}sobjects/task";
                var taskJson = JsonConvert.SerializeObject(
                    task,
                    Formatting.Indented,
                    new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                var response = url
                    .PostJsonToUrl(taskJson, requestFilter: req => req.AddBearerToken(_token))
                    .FromJson<AddTaskResponse>();
                if(response.success)
                {
                    return $"{url}/{response.id}";
                }
            } catch(Exception ex)
            {
                throw new InvalidOperationException("Error Adding Task to Sales Force", ex);
            }
            return null;
        }

        public Account GetAccount(string filter = null, string firstName = null, string lastName = null)
        {
            if(string.IsNullOrEmpty(_token))
                authenticate();

            Account account = null;
            string query = getAccountBaseQuery();

            try
            {
                if(!string.IsNullOrEmpty(filter))
                {
                    string url = $"{query}WHERE{filter}";
                    var response = url.GetJsonFromUrl(requestFilter: req => req.AddBearerToken(_token))
                        .FromJson<ApiQueryResponse<Account>>();

                    if(response != null && response.TotalSize == 1)
                    {
                        account = response.Records[0];
                    }
                }
                if(account == null && !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
                {
                    string url = $"{query}+WHERE+FirstName='{firstName}' AND lastName='{lastName}'";
                    var response = url.GetJsonFromUrl(requestFilter: req => req.AddBearerToken(_token))
                        .FromJson<ApiQueryResponse<Account>>();

                    if(response != null && response.TotalSize == 1)
                    {
                        account = response.Records[0];
                    }
                }
            } catch(Exception ex)
            {
                throw new InvalidOperationException("Error Getting Provider", ex);
            }

            return account;
        }

        public IEnumerable<Account> GetAccounts(string filter = null)
        {
            if(string.IsNullOrEmpty(_token))
                authenticate();

            try
            {
                var url = getAccountBaseQuery();
                if(!string.IsNullOrWhiteSpace(filter))
                    url = $"{url}WHERE{filter}";
                var response = url.GetJsonFromUrl(requestFilter: req => req.AddBearerToken(_token))
                    .FromJson<ApiQueryResponse<Account>>();
                return response.Records;
            } catch(Exception ex)
            {
                throw new InvalidOperationException("Error Getting Salesforce Accounts", ex);
            }
        }
    }
}
