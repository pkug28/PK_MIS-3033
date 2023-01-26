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
            List<int> cogs = new List<int>();
            List<int> gears = new List<int>();
            List<int> ids = new List<int>();
            cogs.Add(cog);
            gears.Add(gear);
            ids.Add(id);

            Receipt receipt = new Receipt(id, cog, gear);
            
            receipt.PrintReceipt();

            string answer;
            do
            {
                Console.WriteLine($"\nAre there any more orders to be placed?");
                answer = Console.ReadLine().ToLower();
                if (answer[0] == 'y')
                {
                    Console.WriteLine("Please input the number of cogs being purchased:");
                    cog = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please input the nubmer of gears being purchased:");
                    gear = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please input the customer's ID number:");
                    id = Convert.ToInt32(Console.ReadLine());

                    cogs.Add(cog);
                    gears.Add(gear);
                    ids.Add(id);

                    Receipt newReceipt = new Receipt(id, cog, gear);
                    newReceipt.PrintReceipt();

                }
                else
                {
                    break;
                }
            } while (answer[0] == 'y');

            Console.WriteLine("Would you like to print receipts by: CustomerID (c), Day (d), or Highest Total (h)?");
            string response = Console.ReadLine().ToLower();
            if (response[0] == 'c')
            {
                Console.WriteLine("Which CustomerID?");
                int custID = Convert.ToInt32(Console.ReadLine());
                foreach (int i in ids)
                {
                    if (i == custID)
                    {

                    }
                }
            }



            Console.ReadKey();
        }
    }
}
