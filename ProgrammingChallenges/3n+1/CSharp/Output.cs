using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3n_1
{
    class Output
    {
        public void OutputToConsole(string str, Format OStrOutput)
        {
            string formatedOutput;
            formatedOutput = OStrOutput.FormatString(str);
            Console.Write("Output for i and J:" + "\n");
            Console.WriteLine(formatedOutput);
            Console.ReadLine();       
        }

    }
}
