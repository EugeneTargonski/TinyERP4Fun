﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TinyERP4Fun.Models.Common
{
    public class CurrencyRates
    {
        public long Id { get; set; }
        public int CurrecyScale { get; set; }

        [DisplayFormat(DataFormatString ="{0:F4}"), Column(TypeName = "decimal(18, 4)")]
        public decimal CurrencyRate { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateRate { get; set; }
        public long CurrencyId { get; set; }
        public Currency Currency { get; set; }
        public long BaseCurrencyId { get; set; }
        public Currency BaseCurrency { get; set; }
    }
}
