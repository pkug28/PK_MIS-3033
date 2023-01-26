using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PK_HWK1_SalesReceipt
{
    public class Receipt
    {
        public int CustomerID { get; set; }
        public int CogQuantity { get; set; }
        public int GearQuantity { get; set; }
        public DateTime SaleDate { get; set; }

        private double SalesTaxPercent;

        private double CogPrice;

        private double GearPrice;

        public Receipt()
        {
            CustomerID = 0;
            CogQuantity = 0;
            GearQuantity = 0;
            SaleDate = DateTime.Now;
            SalesTaxPercent = 0;
            CogPrice = 0;  
            GearPrice = 0;
        }

        public Receipt(int id, int cog, int gear)
        {
            CustomerID = id;
            CogQuantity = cog;
            GearQuantity = gear;
            SaleDate= DateTime.Now;
            CogPrice= 0;
            GearPrice= 0;
        }

        public double CalculateTotal()
        {
            return 0;
        }

        public void PrintReceipt()
        {

        }

        private double CalculateTaxAmount()
        {
            return 0;
        }

        private double CalculateNetAmount()
        {
            return 0;
        }
    }
}
