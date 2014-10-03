using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Woodward_Ethan_Chapter6
{
    class AutoShop
    {
        private const double oilChangeCost      = 26.00;
        private const double lubeJobCost        = 18.00;
        private const double radFlushCost       = 30.00;
        private const double transFlushCost     = 80.00;
        private const double inspectionCost     = 15.00;
        private const double replaceMufflerCost = 100.00;
        private const double tireRotCost        = 20.00;

        private double partsCost = 0.0;
        private double laborCost = 0.0;

        public double OilLubCharges(bool isOilChangeChecked, bool isLubeJobChecked)
        {
            double charges = 0.0;

            charges += isOilChangeChecked ? oilChangeCost : 0.0;
            charges += isLubeJobChecked ? lubeJobCost : 0.0;

            //if (isOilChangeChecked) { charges += oilChangeCost; }
            //if (isLubeJobChecked) { charges += lubeJobCost; }

            return charges;
        }

        public double FlushCharges()
        {
            return 0.0;
        }

        public double MiscCharges()
        {
            return 0.0;
        }

        public double OtherCharges()
        {
            return 0.0;
        }

        public double TaxCharges()
        {
            return 0.0;
        }

        public double TotalCharges()
        {
            return 0.0;
        }

        public void setPartsCost(double partsCost) { this.partsCost = partsCost; }
        public void setLaborCost(double laborCost) { this.laborCost = laborCost; }
    }
}
