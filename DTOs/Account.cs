using System;
using System.Linq;

namespace Jwpro.Api.Proxy.DTOs
{
    public class Account : QueryObject
    {
        public object Account_Family__c { get; set; }

        public string Account_Priority__c { get; set; }

        public int Accounts_Power_of_One__c { get; set; }

        public object AccountSource { get; set; }

        public string Active_Interface__c { get; set; }

        public object Allows_Lunches__c { get; set; }

        public object AnnualRevenue { get; set; }

        public object Appt_Confirmation__c { get; set; }

        public Attributes attributes { get; set; }

        public object BillingAddress { get; set; }

        public object BillingCity { get; set; }

        public object BillingCountry { get; set; }

        public object BillingGeocodeAccuracy { get; set; }

        public object BillingLatitude { get; set; }

        public object BillingLongitude { get; set; }

        public object BillingPostalCode { get; set; }

        public object BillingState { get; set; }

        public object BillingStreet { get; set; }

        public string Biography_and_Other_Information__c { get; set; }

        public object Brochures__c { get; set; }

        public string Business_Account_Priority__c { get; set; }

        public string Competing_Imaging_Center_Name__c { get; set; }

        public string Contact_Address__pc { get; set; }

        public int Count__c { get; set; }

        public string CreatedById { get; set; }

        public DateTime CreatedDate { get; set; }

        public string Credentials__c { get; set; }

        public object Date_Added__c { get; set; }

        public object Date_Added_to_FT_Program__c { get; set; }

        public object Date_EMR_Request_Submitted__c { get; set; }

        public object Date_FT_Updated__c { get; set; }

        public int Days_Since_Last_Visit__c { get; set; }

        public object Description { get; set; }

        public object DocBookMD_User__c { get; set; }

        public double Dollar_Variance__c { get; set; }

        public string Employed_by__c { get; set; }

        public string EMR_ICD_10_CM_Compatible__c { get; set; }

        public string EMR_Name__c { get; set; }

        public string EMR_Name_1__c { get; set; }

        public object EMR_Name_2__c { get; set; }

        public object EMR_Request_Submitted__c { get; set; }

        public string eUnity_User__c { get; set; }

        public object Fast_Track_Comments__c { get; set; }

        public object Fast_Track_Doc__c { get; set; }

        public object Fast_Track_Preferences__c { get; set; }

        public string Fax { get; set; }

        public object Fax__c { get; set; }

        public string Film_Requested__c { get; set; }

        public string FirstName { get; set; }

        public string Formerly_Employed_by__c { get; set; }

        public string Google_Map__pc { get; set; }

        public object Group_Facilty_Name__c { get; set; }

        public object Group_ID__c { get; set; }

        public int Group_YTD_Referrals__c { get; set; }

        public string ICD_10_CM_Informed__c { get; set; }

        public string In_House_Modality_Notes__c { get; set; }

        public object Industry { get; set; }

        public string Inhouse_Imaging_Modalities__c { get; set; }

        public object Interface_Type__c { get; set; }

        public object Interface_Type_2__c { get; set; }

        public bool Is_Invested_in_Competing_Imaging_Center__c { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsPersonAccount { get; set; }

        public object Jigsaw { get; set; }

        public object JigsawCompanyId { get; set; }

        public string Last_Visit_Date__c { get; set; }

        public string LastActivityDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string LastName { get; set; }

        public DateTime LastReferencedDate { get; set; }

        public DateTime LastViewedDate { get; set; }

        public object License_Number__c { get; set; }

        public object Location_Fax__c { get; set; }

        public object Location_for_Contact__pc { get; set; }

        public object Location_Group_Name__c { get; set; }

        public object Location_ID__c { get; set; }

        public object Lunch_Learn_Participants__c { get; set; }

        public object Lunch_Learn_Subject__c { get; set; }

        public object MALatitude__c { get; set; }

        public object MALongitude__c { get; set; }

        public string Map_Account__c { get; set; }

        public object MasterRecordId { get; set; }

        public string Name { get; set; }

        public object Non_Referring_Reason__c { get; set; }

        public string NPI__c { get; set; }

        public int Number_of_Docs_in_Group__c { get; set; }

        public object NumberOfEmployees { get; set; }

        public User Owner { get; set; }

        public string OwnerId { get; set; }

        public string PACS_User__c { get; set; }

        public object ParentId { get; set; }

        public object PersonAssistantName { get; set; }

        public object PersonAssistantPhone { get; set; }

        public object PersonBirthdate { get; set; }

        public string PersonContactId { get; set; }

        public object PersonDepartment { get; set; }

        public string PersonEmail { get; set; }

        public object PersonEmailBouncedDate { get; set; }

        public object PersonEmailBouncedReason { get; set; }

        public object PersonHomePhone { get; set; }

        public object PersonLastCURequestDate { get; set; }

        public object PersonLastCUUpdateDate { get; set; }

        public object PersonLeadSource { get; set; }

        public Address PersonMailingAddress { get; set; }

        public string PersonMailingCity { get; set; }

        public object PersonMailingCountry { get; set; }

        public object PersonMailingGeocodeAccuracy { get; set; }

        public object PersonMailingLatitude { get; set; }

        public object PersonMailingLongitude { get; set; }

        public string PersonMailingPostalCode { get; set; }

        public string PersonMailingState { get; set; }

        public string PersonMailingStreet { get; set; }

        public object PersonMobilePhone { get; set; }

        public object PersonOtherAddress { get; set; }

        public object PersonOtherCity { get; set; }

        public object PersonOtherCountry { get; set; }

        public object PersonOtherGeocodeAccuracy { get; set; }

        public object PersonOtherLatitude { get; set; }

        public object PersonOtherLongitude { get; set; }

        public object PersonOtherPhone { get; set; }

        public object PersonOtherPostalCode { get; set; }

        public object PersonOtherState { get; set; }

        public object PersonOtherStreet { get; set; }

        public object PersonTitle { get; set; }

        public string Phone { get; set; }

        public string PhotoUrl { get; set; }

        public string Pic__c { get; set; }

        public object PRA__c { get; set; }

        public object Preferred_Imaging_Provider__c { get; set; }

        public double Prior_Year_Referral_Value__c { get; set; }

        public double Prior_Year_YTD_Referral_Value__c { get; set; }

        public string Professional_Services_Contract__c { get; set; }

        public object Provider_Name__pc { get; set; }

        public string RecordTypeId { get; set; }

        public string Ref_Code__c { get; set; }

        public object Referral_Coordinator__c { get; set; }

        public string Referral_Preference_and_Type__c { get; set; }

        public double Referral_Value__c { get; set; }

        public string Referring_Status__c { get; set; }

        public object Report_List__c { get; set; }

        public object Requested_Brochures__c { get; set; }

        public object Role__pc { get; set; }

        public object Salutation { get; set; }

        public object ShippingAddress { get; set; }

        public object ShippingCity { get; set; }

        public object ShippingCountry { get; set; }

        public object ShippingGeocodeAccuracy { get; set; }

        public object ShippingLatitude { get; set; }

        public object ShippingLongitude { get; set; }

        public object ShippingPostalCode { get; set; }

        public object ShippingState { get; set; }

        public object ShippingStreet { get; set; }

        public object SicDesc { get; set; }

        public string Specialty_1__c { get; set; }

        public object Specialty_2__c { get; set; }

        public object Specialty_2__pc { get; set; }

        public string Spending_Status__c { get; set; }

        public object St_David_s_Navigator_Particpant__c { get; set; }

        public DateTime SystemModstamp { get; set; }

        public string Territory__c { get; set; }

        public double Total_Amount_Spent__c { get; set; }

        public string Type { get; set; }

        public object UPIN__c { get; set; }

        public double Variance__c { get; set; }

        public object Website { get; set; }

        public bool Works_For_All_Providers__pc { get; set; }

        public object X2nd_Email__pc { get; set; }
    }
}
