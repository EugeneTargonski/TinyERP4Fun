﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TinyERP4Fun.Data;
using TinyERP4Fun.Models.Stock;
using TinyERP4Fun.Interfaces;

namespace TinyERP4Fun.ModelServises
{
    public class WarehouseService : BaseService<Warehouse>, IWarehouseService
    {
        public WarehouseService(IDefaultContext context) : base(context)
        {
        }
    }
}
