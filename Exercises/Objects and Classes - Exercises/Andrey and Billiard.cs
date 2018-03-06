using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyAndBilliard
{
    class Customer
    {
        public string Name { get; set; }

        public Dictionary<string, int> ShopList { get; set; }

        public double Bill { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Dictionary<string, double> prices = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split('-');

                var product = input[0];

                var price = double.Parse(input[1]);

                if (!prices.ContainsKey(product))
                {
                    prices.Add(product, price);
                }
                else
                {
                    prices[product] = price;
                }
            }

            List<Customer> customers = new List<Customer>();

            while (true)
            {
                var entry = Console.ReadLine();

                if (entry == "end of clients") { break; }

                var bill = entry.Split(new char[] { ',', '-' });

                var customer = bill[0];
                var product = bill[1];
                var quantity = int.Parse(bill[2]);


                if (!prices.ContainsKey(product)) { continue; }

                Customer currentCustomer = new Customer();

                currentCustomer.ShopList = new Dictionary<string, int>();

                currentCustomer.Name = customer;

                currentCustomer.ShopList.Add(product, quantity);

                if (customers.Any(c => c.Name == customer))
                {
                    Customer existingCustomer = customers.First(c => c.Name == customer);

                    if (existingCustomer.ShopList.ContainsKey(product))
                    {
                        existingCustomer.ShopList[product] += quantity;
                    }
                    else
                    {
                        existingCustomer.ShopList[product] = quantity;
                    }
                }

                else
                {
                    customers.Add(currentCustomer);
                }
            }


            foreach (var client in customers)
            {
                foreach (var item in client.ShopList)
                {
                    foreach (var product in prices)
                    {
                        if (item.Key == product.Key) { client.Bill += item.Value * product.Value; }
                    }
                }
            }

            var ordered = customers
                .OrderBy(x => x.Name)
                .ThenBy(x => x.Bill)
                .ToList();

            foreach (var customer in ordered)
            {
                Console.WriteLine(customer.Name);

                foreach (var item in customer.ShopList)
                {
                    Console.WriteLine("-- {0} - {1}", item.Key, item.Value);
                }

                Console.WriteLine("Bill: {0:f2}", customer.Bill);
            }

            Console.WriteLine("Total bill: {0:F2}", customers.Sum(c => c.Bill));
        }
    }
}