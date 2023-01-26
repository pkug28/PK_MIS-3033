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
            CogPrice = 79.99;  
            GearPrice = 250;
        }

        public Receipt(int id, int cog, int gear)
        {
            CustomerID = id;
            CogQuantity = cog;
            GearQuantity = gear;
            SaleDate= DateTime.Now;
            CogPrice= 79.99;
            GearPrice= 250;
        }

        public double CalculateTotal()
        {
            double total = CalculateNetAmount() + CalculateTaxAmount();
            return total;
        }

        public void PrintReceipt()
        {
            Console.WriteLine($"\nCustomerID: {CustomerID} \nDate: {SaleDate} \nNumber of Cogs ordered: {CogQuantity} \nNumber of Gears ordered: {GearQuantity} " +
                $"\nNet Amount: {CalculateNetAmount().ToString("C2")} \nTaxes: {CalculateTaxAmount().ToString("C2")} \nTotal: {CalculateTotal().ToString("C2")}");
        }

        private double CalculateTaxAmount()
        {
            double salesTax = 0.089;
            double taxAmount = CalculateNetAmount() * salesTax;
            return taxAmount;
        }

        private double CalculateNetAmount()
        {
            double markup;
            double cogMarkup;
            double gearMarkup;
            double cogTotal;
            double gearTotal;
            double netAmount;

            
            if ((CogQuantity + GearQuantity) >= 16 || CogQuantity >= 10 || GearQuantity >=10)
            {
                markup = 0.125;
                cogMarkup = CogPrice + (CogPrice * markup);
                gearMarkup = GearPrice + (GearPrice * markup);
                cogTotal = cogMarkup * CogQuantity;
                gearTotal = gearMarkup * GearQuantity;
                netAmount = cogTotal + gearTotal;
            }            
            else
            {
                markup = 0.15;
                cogMarkup = CogPrice + (CogPrice * markup);
                gearMarkup = GearPrice + (GearPrice * markup);
                cogTotal = cogMarkup * CogQuantity;
                gearTotal = gearMarkup * GearQuantity;
                netAmount = cogTotal + gearTotal;
            }
            
            return netAmount;
        }
    }
}
