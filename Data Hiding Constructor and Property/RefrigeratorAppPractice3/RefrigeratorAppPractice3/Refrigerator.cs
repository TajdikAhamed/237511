using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppPractice3
{
    public class Refrigerator
    {
        private double MaxWeight { get; set; }
        public double CureentWeight { get; private set; }

        public Refrigerator(double maxWeight) {
            this.MaxWeight = maxWeight;
        }

        public bool PutItems(int quentity,double unitWeight)
        {
            if (this.CureentWeight + (quentity * unitWeight) > this.MaxWeight)
            {
                return false;
            }
            this.CureentWeight = this.CureentWeight + (quentity * unitWeight);
            return true;
         }


        public double GetRemain()
        {
            return this.MaxWeight - this.CureentWeight;
        }
    }
}
