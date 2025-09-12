// HW1a Sales Total

// Your Name: Brandon Tran 
// Did you seek help ? If yes, specify the helper or web link here: Friend Nhi 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double quantity;
            double price;

            const double sales_tax_rate = 0.085;

            
            string productName;
            string quantityAsString;
            string priceAsString;

            Console.WriteLine("What is the product name of the item you are purchasing? ");
            productName = Console.ReadLine();
            Console.WriteLine("How many Movie Ticket's do you want to buy? ");
            quantityAsString = Console.ReadLine();
            Console.WriteLine("What is the price for each Movie Ticket? ");
            priceAsString = Console.ReadLine();

            quantity = Convert.ToDouble(quantityAsString);
            price = Convert.ToDouble(priceAsString);

            double subtotal = quantity * price;
            double sales_tax = subtotal * sales_tax_rate;
            double total = subtotal + sales_tax;

            Console.WriteLine("Your subtotal for the bill is $" + subtotal.ToString("N3"));

            Console.WriteLine($"Your sales tax for your bill is $" + sales_tax.ToString("N3"));

            Console.WriteLine($"Your total for the bill is $" + total.ToString("N3"));

            Console.ReadKey();
         



        }
    }
}
