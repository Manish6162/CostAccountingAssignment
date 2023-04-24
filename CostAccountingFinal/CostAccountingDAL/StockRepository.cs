using System;
using System.Collections.Generic;

namespace CostAccountingDAL
{
    public struct StockLot
    {
        public int Id { get; set; }
        public int Shares { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
    }
    public interface IStockRepository
    {
        IEnumerable<StockLot> GetLots();
    }

    public class StockRepository : IStockRepository
    {
        public StockRepository()
        {
 
        }

        public IEnumerable<StockLot> GetLots()
        {
            var lots = new List<StockLot>
            {
             new StockLot { Id = 1, Shares = 100, Price = 20m, Date = new DateTime(2023, 1, 1) },
             new StockLot { Id = 2, Shares = 150, Price = 30m, Date = new DateTime(2023, 2, 1) },
             new StockLot { Id = 3, Shares = 120, Price = 10m, Date = new DateTime(2023, 3, 1) },
            };
            return lots;
        }
    }
}