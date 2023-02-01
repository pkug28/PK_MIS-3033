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
            //consolidate starting code into the do-while loop
            
            Console.WriteLine("Please input the number of cogs being purchased:");
            int cog = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input the nubmer of gears being purchased:");
            int gear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input the customer's ID number:");
            int id = Convert.ToInt32(Console.ReadLine());
            List<Receipt> receipts = new List<Receipt>();
            

            Receipt receipt = new Receipt(id, cog, gear);
            
            receipt.PrintReceipt();

            receipts.Add(receipt);

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

                    

                    Receipt newReceipt = new Receipt(id, cog, gear);
                    newReceipt.PrintReceipt();
                    receipts.Add(newReceipt);

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
                for (int i = 0; i < receipts.Count; i++)
                {
                    if (custID == receipt.CustomerID)
                    {
                        receipt.PrintReceipt();
                    }
                }
            }



            Console.ReadKey();
        }
    }
}
