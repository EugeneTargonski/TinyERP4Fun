﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TinyERP4Fun.Models;
using TinyERP4Fun.Models.Stock;

namespace TinyERP4Fun.ModelServiceInterfaces
{
    public interface IStockService
    {
        Task<T> GetObject<T>(long? id) where T : class, IHaveLongId;
        Task<Item> GetItemInfo(long? id);
        Task Add(Stock stock);
        Task Update(Stock stock);
        Task Remove(long id);
        void ClearHistory(DateTime date);
        Task<Stock> GetStockInfo(long? id);
        IQueryable<Stock> GetFiltredContent(DateTime? fromFilter,
                                            DateTime? toFilter,
                                            IEnumerable<long?> itemFilter,
                                            IEnumerable<long?> warehouseFilter,
                                            IEnumerable<string> userFilter
                                            );

    }
}
