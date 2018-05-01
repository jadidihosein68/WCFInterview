using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    class a
    {

        public int myfunction(ref int a, int b, int c = 1)
        {


         return   a = a + b + c;


        }








    }



    public enum CS {

        
    
    }

    class Program




    {

  


        static void Main(string[] args)
        {
            /*
            string mes = "bb";

            CS abu;

         Console.WriteLine ( Enum.TryParse<CS>(mes, out abu));
            */







            int[] data = { 1, 2, 3 };

            var reslt = from x in data select x;

           // string mes = "bb";
            Console.WriteLine(reslt);

          
            //Console.WriteLine(output);
            Console.ReadLine();


            /*
            string[] colors = { "House", "Room", "Building", "street" };

            var output = colors.Max(c => c.Length);
            Console.WriteLine(output);
            Console.ReadLine();
            */
            //   Array abc = Directory.GetDirectories(@"c:\mytest");
            /*
            var a = new a();
            int sum = 0;
            int aa = 5;
            int bb = 5;
            int cc = 5; 

            Console.WriteLine(a.myfunction(5,5,5));
            Console.ReadLine();
            */
        }
    }
}
