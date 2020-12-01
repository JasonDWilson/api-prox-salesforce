# api-proxy-salesforce:  A .Net Standard 2.0 proxy wrapper for the Salesforce API

*Please note that this is not intended to be a comprehensive coverage of the Salesforce API
I only included what I needed when I wrote it.*

### If there are things you need feel free to contribute

Usage:
- All usage is governed through the **DataManager** class
- DataManager expects a **SalesForceConfiguration** object to be injected that contains url and credentials for the API

```csharp
var dm = new DataManager(new SalesForceConfiguration
{ 
  Username=*your username*, 
  Password=*your password*, 
  AccountToken=*your saleforce token*, 
  Secret=*your salesforce secret*,
  AuthorizationUrl=*saleforce authorization url*,
  ApiUrl=*saleforce api url*
});
var accounts = dm.GetAccounts();
```

*please let me know if you have questions
Jason D Wilson*
