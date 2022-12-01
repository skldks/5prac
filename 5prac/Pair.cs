using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5prac
{

    public class Pair
    {

        private int _first;
        private int _second;

        public Pair(int first, int second)
        {
            First = first;
            Second = second;
        }


        public int First
        {
            get { return _first; }
            set { _first = value; }
        }

        public int Second
        {
            get { return _second; }
            set { _second = value; }
        }


        public Pair Substraction(Pair pair)
        {
            return new Pair(First - pair.First, Second - pair.Second);

            //int rez = fpfz - spfz;
            //int rez1= fpfz - spfz;              
            //return rez+rez1;
        }
        public Pair Substraction(Pair pair, Pair pair1)
        {
            return new Pair(First - pair.First - pair1.First, Second - pair.Second - pair1.Second);

            //int rez = fpfz - spfz - thirdpfz;
            //int rez1 = fpfz - spfz - thirdpsz;
            //return rez + rez1;
        }
    }
}
