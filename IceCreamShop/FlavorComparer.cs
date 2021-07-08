using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    class FlavorComparer : IComparer<Flavor>
    {
        /*
        public int Compare(Flavor x, Flavor y)
        {
            return string.Compare(x.Name, y.Name);
        }*/

        public int Compare(Flavor x, Flavor y)
        {
            int xNumAlergens = x.Allergens.Count;
            int yNumAlergens = y.Allergens.Count;

            if (x.Cost - y.Cost < 0)
            {
                return -1;
            }
            else if (x.Cost - y.Cost > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

    }
}
