using CostAccountingDAL;
using System;

namespace CostAccountingBLL
{
    public interface IStockService
    {
        SellResult SellShares(int shares, decimal price);
    }

    public class StockService : IStockService
    {
        private readonly IStockRepository stockRepository;

        public StockService(IStockRepository stockRepository)
        {
            this.stockRepository = stockRepository;
        }

        public SellResult SellShares(int shares, decimal price)
        {
            var remainingShares = shares;
            var soldCostBasis = 0m;
            var remainingCostBasis = 0m;

            foreach (var lot in stockRepository.GetLots())
            {
                if (remainingShares == 0)
                {
                    break;
                }

                var lotShares = Math.Min(remainingShares, lot.Shares);
                var lotCostBasis = lotShares * lot.Price;

                remainingShares -= lotShares;
                soldCostBasis += lotCostBasis;
                remainingCostBasis += (lot.Shares - lotShares) * lot.Price;
            }

            var profit = (shares * price) - soldCostBasis;

            return new SellResult
            {
                RemainingShares = remainingShares,
                SoldCostBasis = soldCostBasis,
                RemainingCostBasis = remainingCostBasis,
                Profit = profit
            };
        }
    }

    public class SellResult
    {
        public int RemainingShares { get; set; }
        public decimal SoldCostBasis { get; set; }
        public decimal RemainingCostBasis { get; set; }
        public decimal Profit { get; set; }
    }

}
