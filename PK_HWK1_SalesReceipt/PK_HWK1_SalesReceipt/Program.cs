using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PK_HWK1_SalesReceipt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the number of cogs being purchased:");
            int cog = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input the nubmer of gears being purchased:");
            int gear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input the customer's ID number:");
            int id = Convert.ToInt32(Console.ReadLine());

            Receipt receipt = new Receipt(id, cog, gear);

            receipt.PrintReceipt();

            Console.ReadKey();
        }
    }
}
