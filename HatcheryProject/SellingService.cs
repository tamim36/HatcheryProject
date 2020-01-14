using System;

namespace HatcheryProject
{
    public class SellingService
    {
        public void OnRuiSell(object source, FishEventArgs e)
        {
            if((FishTank.rui - e.amount) >= 0)
            {
                FishTank.rui = FishTank.rui - e.amount;
            }
            else
            {
                Console.WriteLine("Insufficient Fish ! ");
            }
        }

        public void OnKatlaSell(object source, FishEventArgs e)
        {
            if ((FishTank.rui - e.amount) >= 0)
            {
                FishTank.katla = FishTank.katla - e.amount;
            }
            else
            {
                Console.WriteLine("Insufficient Fish ! ");
            }
        }

        public void OnIlishSell(object source, FishEventArgs e)
        {
            if ((FishTank.ilish - e.amount) >= 0)
            {
                FishTank.ilish = FishTank.ilish - e.amount;
            }
            else
            {
                Console.WriteLine("Insufficient Fish ! ");
            }
        }
    }
}
