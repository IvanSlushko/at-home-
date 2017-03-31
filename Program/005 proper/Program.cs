using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_proper
{
    class Constants
    {
        private double pi = 3.14D;
        private double e = 2.71D;
       
        //write only
        public double Pi
        {
            set { pi = value;}
        }


        //readonly only
        public double E
        {
            get { return e; }
        }




    }




    class Program
    {
        static void Main(string[] args)
        {

            Constants constants = new Constants();

            constants.Pi = 3.14159265D;
            // Console.WriteLine(constants.Pi);  нельзя

            // constants.E = 3.71D;  нельзя

            Console.WriteLine("e= {0}", constants.E);
            
            Console.ReadKey();
            
        }
    }
}
