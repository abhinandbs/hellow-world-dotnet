using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld.ListSample
{
    public static class UniqueList
    {

        // Remove duplicates from the list
        public static void UniqueSampleList()
        {
            List<String> list = new() { "car" , "jeep", "jeep", "tata"};

            Console.WriteLine("First List");
            Console.WriteLine(String.Join(",", list));

            HashSet<String> set = new(list);

            Console.WriteLine("Distinct List");
            Console.WriteLine(String.Join(",", set));
          



        }
    }
}
