using System;
using System.Collections.Generic;
using System.Text;

namespace Jwpro.Api.Proxy.DTOs
{
    public class Task
    {
        public Attributes attributes { get; set; }
        public string Id { get; set; }
        public string RecordTypeId { get; set; }
        public object WhoId { get; set; }
        public object WhatId { get; set; }
        public int? WhoCount { get; set; }
        public int? WhatCount { get; set; }
        public string Subject { get; set; }
        public string ActivityDate { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public bool? IsHighPriority { get; set; }
        public string OwnerId { get; set; }
        public object Description { get; set; }
        public bool? IsDeleted { get; set; }
        public object AccountId { get; set; }
        public bool? IsClosed { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedById { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedById { get; set; }
        public DateTime? SystemModstamp { get; set; }
        public bool? IsArchived { get; set; }
        public object CallDurationInSeconds { get; set; }
        public object CallType { get; set; }
        public object CallDisposition { get; set; }
        public object CallObject { get; set; }
        public DateTime? ReminderDateTime { get; set; }
        public bool? IsReminderSet { get; set; }
        public object RecurrenceActivityId { get; set; }
        public bool? IsRecurrence { get; set; }
        public object RecurrenceStartDateOnly { get; set; }
        public object RecurrenceEndDateOnly { get; set; }
        public object RecurrenceTimeZoneSidKey { get; set; }
        public object RecurrenceType { get; set; }
        public object RecurrenceInterval { get; set; }
        public object RecurrenceDayOfWeekMask { get; set; }
        public object RecurrenceDayOfMonth { get; set; }
        public object RecurrenceInstance { get; set; }
        public object RecurrenceMonthOfYear { get; set; }
        public object RecurrenceRegeneratedType { get; set; }
        public string TaskSubtype { get; set; }
        public bool? mea__IsAssociatedWithLead__c { get; set; }
        public string Add_New_Referring_Text_Box__c { get; set; }
        public object Action_Type__c { get; set; }
        public string Service_Now_Ticket_Fields__c { get; set; }
    }
}
