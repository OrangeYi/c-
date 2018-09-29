using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //lmplicit type conversion
            byte b = 1; // 00000001
            int i = b;  //00000000 00000000 00000000 00000001

            int a = 300;
            byte c = (byte)a;//casting

            Console.WriteLine(c);

            string aa = "1";
            int ii = Convert.ToInt32(aa);
            Console.WriteLine(ii);
            int j = int.Parse(aa);
            Console.WriteLine(j);
            try
            {
                var number = "1234;";
                byte abc = Convert.ToByte(number);
                Console.WriteLine(abc);
            }
            catch(Exception)
            {
                Console.WriteLine("cant not do that");
            }
        }
    }
}
