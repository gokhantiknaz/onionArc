﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humanity.Application.Models.DTOs
{
    public class GetOwnerConsumptionsResponse
    {

    }

    public class CustomerSubscriptionResponse
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public int TotalItemCount { get; set; }
        public int TotalPageCount { get; set; }
        public List<CustomerSubscription> ResultList { get; set; }
    }

    public class CustomerSubscription
    {
        public int SubscriptionSerno { get; set; }
        public string IdentifierValue { get; set; }
        public string IdentifierValueSec { get; set; }
        public int DefinitionType { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string MeterSerial { get; set; }
        public string MeterBrand { get; set; }
        public string MeterModel { get; set; }
        public decimal Multiplier { get; set; }
        public long LastEndexDate { get; set; }
        public long LastProfileDate { get; set; }
        public decimal MinCapasitiveRate { get; set; }
        public decimal MinInductiveRate { get; set; }
        public decimal InstalledPower { get; set; }
        public decimal AccordPower { get; set; }
        public string GroupInfo { get; set; }
        public long MeterPointOwnerAssignDate { get; set; }
        public long SubscriberMultiplierChangeDate { get; set; }
        public object CustomerFields { get; set; }
    }


}
