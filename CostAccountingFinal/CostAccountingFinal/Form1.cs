using CostAccountingBLL;
using CostAccountingDAL;
using System;
using System.Windows.Forms;

namespace CostAccountingFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(sharesTextBox.Text, out var shares) && decimal.TryParse(priceTextBox.Text, out var price))
            {
                IStockRepository stockRepository = new StockRepository();
                IStockService stockService = new StockService(stockRepository);

                var result = stockService.SellShares(shares, price);
                remainingSharesLabel.Text = result.RemainingShares.ToString();
                soldCostBasisLabel.Text = result.SoldCostBasis.ToString();
                remainingCostBasisLabel.Text = result.RemainingCostBasis.ToString();
                profitLabel.Text = result.Profit.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid values for shares and price.");
            }
        }
    }
}
