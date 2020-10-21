using System;
using System.Collections.Generic;
using SufferShopDB;
using SufferShopLib;

namespace SufferShopUI
{
    class Program
    {
        static List<CustomerSample> customers = new List<CustomerSample>();
        static List<CustomerSample> GetSampleCustomers(){
            List<CustomerSample> sampleList = new List<CustomerSample>();
            sampleList.Add(new CustomerSample(""));
            sampleList.Add(new CustomerSample("Loser Boboser"));
            sampleList.Add(new CustomerSample("Winner Bobinner Chicken Dinner"));
            return sampleList;
        }
        
        static void Main(string[] args)
        {
            customers = GetSampleCustomers();
            Dictionary<int,string> customerDict = new Dictionary<int,string>();

            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.ID} {customer.Name}");
                customerDict.Add(customer.ID,customer.Name);
            }

            foreach(KeyValuePair<int,string> customerInfo in customerDict) {
                Console.WriteLine($"{customerInfo.Key} {customerInfo.Value}");
            }

        }
        
    }
}
