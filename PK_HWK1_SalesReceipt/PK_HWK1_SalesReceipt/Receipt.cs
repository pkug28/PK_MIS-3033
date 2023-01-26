using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
            double taxAmount = CalculateTaxAmount();
            double netAmount = CalculateNetAmount();
            double total = CalculateTotal();
            int id = CustomerID;
            DateTime saleDate = SaleDate;
            int cog = CogQuantity;
            int gear = GearQuantity;
            List<double> taxes = new List<double>();
            taxes.Add(taxAmount);
            List<double> nets = new List<double>();
            nets.Add(netAmount);
            List<double> totals = new List<double>();
            totals.Add(total);
            List<int> ids = new List<int>();
            ids.Add(id);
            List<DateTime> saleDates = new List<DateTime>();
            saleDates.Add(saleDate);
            List<int> cogs = new List<int>();
            cogs.Add(cog);
            List<int> gears = new List<int>();
            gears.Add(gear);
            
            string receipt = ($"\nCustomerID: {id} \nDate: {saleDate} \nNumber of Cogs ordered: {cog} \nNumber of Gears ordered: {gear} " +
                $"\nNet Amount: {netAmount.ToString("C2")} \nTaxes: {taxAmount.ToString("C2")} \nTotal: {total.ToString("C2")}");
            Console.WriteLine(receipt);
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
