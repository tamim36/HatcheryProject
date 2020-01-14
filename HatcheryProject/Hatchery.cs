using System;
using System.Collections.Generic;
using System.Text;

namespace HatcheryProject
{
    class Hatchery
    {
        public delegate void FishEventHandler(object source, FishEventArgs e);
        public event FishEventHandler FishEvent;

        // Raising that event
        public void RaiseEvent(int amount)
        {
            OnFishTankCall(amount);
        }

        protected virtual void OnFishTankCall(int amount)
        {
            if (FishEvent != null)
                FishEvent(this, new FishEventArgs() { amount = amount });
        }
    }
}
