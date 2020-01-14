using System;
using System.Collections.Generic;
using System.Text;

namespace HatcheryProject
{
    class Customer
    {
        public void task()
        {
            var hatchery = new Hatchery();   //publisher
            

            while (true)
            {
                var sellService = new SellingService();

                Console.WriteLine(" For Rui - 1\n For Katla - 2\n For Ilish - 3\n");
                int fishNo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter amount to Purchase - ");
                int amount = Convert.ToInt32(Console.ReadLine());

                if (fishNo == 1)
                {
                    hatchery.FishEvent += sellService.OnRuiSell;
                    hatchery.RaiseEvent(amount);
                    hatchery.FishEvent -= sellService.OnRuiSell;
                }
                if (fishNo == 2)
                {
                    hatchery.FishEvent += sellService.OnKatlaSell;
                    hatchery.RaiseEvent(amount);
                    hatchery.FishEvent -= sellService.OnKatlaSell;
                }
                if(fishNo == 3)
                {
                    hatchery.FishEvent += sellService.OnIlishSell;
                    hatchery.RaiseEvent(amount);
                    hatchery.FishEvent -= sellService.OnIlishSell;
                }

                Console.WriteLine("Available Fish -\n Rui - {0}\n Katla - {1}\n Ilish - {2}\n", FishTank.rui, FishTank.katla, FishTank.ilish);
            }
        }
    }
}
