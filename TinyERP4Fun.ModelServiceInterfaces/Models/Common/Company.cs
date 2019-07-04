﻿using System.Collections.Generic;
using TinyERP4Fun.Interfaces;

namespace TinyERP4Fun.Models.Common
{
    public class Company : IHaveName, IHaveLongId, ICanSetName
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string TIN { get; set; }
        public string TIN2 { get; set; }
        public long? CityId { get; set; }
        public City City { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public long? HeadCompanyId { get; set; }
        public Company HeadCompany { get; set; }
        public bool OurCompany { get; set; }
        public List<Communication> Communications { get; set; }
        public long? BaseCurrencyId { get; set; }
        public Currency BaseCurrency { get; set; }
    }
}
