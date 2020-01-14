using System;

namespace HatcheryProject
{
    public class BuyingService
    {
        public void OnRuiBuy(object source, FishEventArgs e)
        {
            FishTank.rui = FishTank.rui + e.amount;
        }

        public void OnKatlaBuy(object source, FishEventArgs e)
        {
            FishTank.katla = FishTank.katla + e.amount;
        }

        public void OnIlishBuy(object source, FishEventArgs e)
        {
            FishTank.ilish = FishTank.ilish + e.amount;
        }
    }
}
