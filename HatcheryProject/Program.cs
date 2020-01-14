using System;

namespace HatcheryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var hatchery = new Hatchery();   //publisher
            var sellService = new SellingService(); //subscriber
            var buyService = new BuyingService();

            Console.WriteLine("For Customer (To decrease Fish) Application press - 1");
            Console.WriteLine("For Owner (To increase Fish) Application press - 2");
            int userType = Convert.ToInt32(Console.ReadLine());

            if(userType == 1)
            {
                Customer customer = new Customer();
                customer.task();
            }

            if (userType == 2)
            {
                Owner owner = new Owner();
                owner.task();
            }
        }
    }
}
