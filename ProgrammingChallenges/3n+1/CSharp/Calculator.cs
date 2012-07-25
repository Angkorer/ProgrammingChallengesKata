using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _3n_1
{
    class Calculator
    {
        private int myOneNum;
        private string myPairNum;


        public int OneMaxCycleLengthOutput
        {
            get
            {
                return myOneNum;
            }
            set
            {
                myOneNum = value;
            }
        }

        public string PairMaxCycleLengthOutput
        {
            get
            {
                return myPairNum;
            }
            set
            {
                myPairNum = value;
            }
        }
        public Calculator(Input OReader)
        { 
            string OneNumber;
            string Pair;
            ArrayList list= new ArrayList();

            OneNumber=OReader.ReadOne(); 
            Pair = OReader.ReadPair();
            list = OReader.parserPair(Pair);
            int i = Convert.ToInt32(list[0]);
            int j = Convert.ToInt32(list[1]);
            OneMaxCycleLengthOutput = OneMaxCyleLength(Int32.Parse(OneNumber));
            PairMaxCycleLengthOutput = PairMaxCyleLength(i, j);

        }

     

        static int nextN(int currentN)
        {
            int answer;
            if (currentN % 2 == 1)
                answer = 3 * currentN + 1;
            else
                answer = currentN / 2;
            return answer;
        }

        public string PairMaxCyleLength(int i, int j)
        {

            int N;
            int count;
            int maxCycleLength;


            N = i;
            count = 1;
            maxCycleLength = 0;

            for (int start = i; start <= j; start++)
            {
                N = start;
                count = 1;
                do
                {

                    N = nextN(N);
                    count++;

                } while (N > 1);

                if (maxCycleLength < count) { maxCycleLength = count; }

            }
            string str = i.ToString() + "," + j.ToString() + "," + maxCycleLength.ToString();
            return str;
        }

        public int OneMaxCyleLength(int i)
        {

            int N = i;
            int count = 1;
            while (N > 1)
            {

                N = nextN(N);
                count++;

            }


            return count;
        }
    }
}
