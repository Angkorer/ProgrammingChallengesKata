using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainCycleNumber
{
    class MainProgram
    {

        static string PassingArrayInput(int[,] arr)
        {
            string str="";
          
            for (int i = 0; i < arr.Length/2; i++)
            {
                CycleGenerator cg = new CycleGenerator();
               
                 str = str + cg.Sequence(arr[i,0],arr[i,1]) + "\n";
           
            }
            
            return str;
        }

        static void Main(string[] args)
        {
            string str;
            int[,] input = { { 1, 10},{100,200},{201,210},{900,1000}};

           str= PassingArrayInput(input);
           Console.Write(str);
           Console.ReadLine();
        }
    }

    public class CycleGenerator
    {


        static int nextN(int currentN)
        {
            int answer;
            if (currentN % 2 == 1)
                answer = 3 * currentN + 1;
            else
                answer = currentN / 2;
            return answer;
        }

        public string Sequence(int i, int j)
        {

            int N;
            int count;
            int maxCycleLength;


            N = i;
            count = 1;
            maxCycleLength=0;

            for (int start=i;start <= j; start ++)
            {   
                N = start;
                count = 1;
               do
               {
                   
                   N = nextN(N);
                   count++; 
                                   
                } while (N>1);
              
               if (maxCycleLength < count) { maxCycleLength = count; }
            
            }
            string str = i.ToString() + " " + j.ToString() + " " + maxCycleLength.ToString();
            return str;
        }
    }
}
