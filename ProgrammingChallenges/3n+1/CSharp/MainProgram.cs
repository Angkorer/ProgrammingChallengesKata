using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3n_1
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            //string str = "10,23";
            //string result;
            ////result = str.Substring(0, str.IndexOf(','));
            //result = str.Substring(str.IndexOf(',')+1, str.Length - str.IndexOf(',')-1);
            Input reader = new Input();
            Calculator cal = new Calculator(reader);

            Format OFormat = new Format();
            Output OOutput = new Output();
            Console.Write("Output for N:" + "\n");
            Console.WriteLine(cal.OneMaxCycleLengthOutput);
            OOutput.OutputToConsole(cal.PairMaxCycleLengthOutput,OFormat); 
          
        }
    }
}
