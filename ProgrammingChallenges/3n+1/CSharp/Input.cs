using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _3n_1
{
    class Input
    {
        public string ReadOne()
        {
            Console.Write("Calculate Cycle Lenght for one number N"+"\n");
            Console.WriteLine("Enter input:"); // Prompt
            string line = Console.ReadLine();
            return line;
        }

        public string ReadPair()
        {
            string line;
            Console.Write("Calculate Max Cycle Lenght between i and j" + "\n");
            Console.WriteLine("Enter starting number:"); // Prompt
            line = Console.ReadLine();
            Console.WriteLine("Enter Ending number:"); // Prompt
            line = line +',' + Console.ReadLine();
            return line;
        }

        public ArrayList parserPair(string number)
        {
            ArrayList token = new ArrayList();
                     
                token.Add(number.Substring(0, number.IndexOf(',')));
                token.Add(number.Substring(number.IndexOf(',') + 1, number.Length - number.IndexOf(',') - 1));
        
            return token;
        }

          
    
    }
}
