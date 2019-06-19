﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TinyERP4Fun.Data;
using TinyERP4Fun.Models.Expenses;
using TinyERP4Fun.ModelServiceInterfaces;

namespace TinyERP4Fun.ModelServises
{
    public class BusinessDirectionsService : BaseService<BusinessDirection>, IBusinessDirectionsService
    {
        public BusinessDirectionsService(DefaultContext context) : base(context)
        {
        }
    }
}
