using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;



            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.
            FlavorComparer comparer = new FlavorComparer();

            foreach (var i in availableFlavors) //before sort
            {
                Console.WriteLine(i.Name);
            }

            Console.WriteLine("\n\n");
            availableFlavors.Sort(comparer);

            foreach (var i in availableFlavors) // after sort 
            {
                Console.WriteLine(i.Name);
            }

            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.

            ConeComparer cc = new ConeComparer();

            foreach (var i in availableCones) // before sorting
            {
                Console.WriteLine(i.Name + " " + i.Cost);
            }

            Console.WriteLine("\n\n");
            availableCones.Sort(cc);

            foreach (var i in availableCones) // after sorting 
            {
                Console.WriteLine(i.Name + " " + i.Cost);
            }

            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.
        }
    }
}
