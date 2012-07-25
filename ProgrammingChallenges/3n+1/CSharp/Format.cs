using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3n_1
{
    class Format
    {
        
        public string FormatString (string str) //This can be modified to handle more than one format, as from now i will as format the out with the space;
        {
            string result;

            result = str.Replace(",", " ");
           
            return result;
        }

    }
}
