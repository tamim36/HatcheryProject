using System;
using System.Collections.Generic;
using System.Text;

namespace HatcheryProject
{
    class Owner
    {
        public void task()
        {
            var hatchery = new Hatchery();   //publisher


            while (true)
            {
                var buyingService = new BuyingService();


                Console.WriteLine(" For Rui - 1\n For Katla - 2\n For Ilish - 3\n");
                int fishNo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter amount to buy - ");
                int amount = Convert.ToInt32(Console.ReadLine());


                if (fishNo == 1)
                {
                    hatchery.FishEvent += buyingService.OnRuiBuy;
                    hatchery.RaiseEvent(amount);
                    hatchery.FishEvent -= buyingService.OnRuiBuy;
                }
                if (fishNo == 2)
                {
                    hatchery.FishEvent += buyingService.OnKatlaBuy;
                    hatchery.RaiseEvent(amount);
                    hatchery.FishEvent -= buyingService.OnKatlaBuy;
                }
                if (fishNo == 3)
                {
                    hatchery.FishEvent += buyingService.OnIlishBuy;
                    hatchery.RaiseEvent(amount);
                    hatchery.FishEvent -= buyingService.OnIlishBuy;
                }

                Console.WriteLine("Available Fish -\n Rui - {0}\n Katla - {1}\n Ilish - {2}\n", FishTank.rui, FishTank.katla, FishTank.ilish);
            }
        }
    }
}
