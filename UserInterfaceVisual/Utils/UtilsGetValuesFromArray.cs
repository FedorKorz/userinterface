using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceVisual.Utils
{
    public static class UtilsGetValuesFromArray
    {
        public static ArrayList genRandomValues(ArrayList arlist, int numOfInterets)
        {
            var random = new Random();
            var available = arlist.ToArray().Length;
            var needed = numOfInterets;
            ArrayList interstList = new ArrayList();
            foreach (string item in arlist)
            {
                if (random.Next(available) < needed)
                {
                    needed--;
                    interstList.Add(item.ToLower());
                    if (needed == 0)
                    {
                        break;
                    }
                }
                available--;
            }
            return interstList;
        }

        /// Soludtion taken from here 
        /// https://stackoverflow.com/a/63948082
    }
}
