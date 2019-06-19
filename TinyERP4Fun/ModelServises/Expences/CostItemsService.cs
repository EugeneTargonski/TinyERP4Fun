﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TinyERP4Fun.Data;
using TinyERP4Fun.Models.Expenses;
using TinyERP4Fun.ModelServiceInterfaces;

namespace TinyERP4Fun.ModelServises
{
    public class CostItemsService : BaseService<CostItem>, ICostItemsService
    {
        public CostItemsService(DefaultContext context) : base(context)
        {
        }
    }
}
