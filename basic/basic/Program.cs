using System;
using System.Linq;
using System.Text;
using System.Text.Encodings;

namespace basic
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            /* int a = 6;
             switch(a)
             {
                 case 1: Console.WriteLine("not true");
                 break;

                 case 5:Console.WriteLine("yes a = 5");
                 break;

                 default: Console.WriteLine("finnal");
                 break;
             }*/
            #endregion


            #region 2
            /*int count = 0;
            how:
            Console.WriteLine("pass goto");
            count++;
            if (count < 1000)
                goto how;
            Console.WriteLine("end");*/
            #endregion

            /*var something = 1;
            Console.WriteLine(something);*/

            /*for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("do this");
            }*/

            /*for (int i = 0; i < 10; i++)
            {
                show();
            }*/



            int value=0 ;
            Console.WriteLine("value before increase: {0}",value);
            increasevalue(out value);
            Console.WriteLine("value after increase: {0}", value);


            int[] myarray = new int[3];
            for (int i = 0; i < myarray.Length; i++)
            {
                Console.WriteLine(myarray[i]);
            }


            string[] newarray = new string[] { "newline", "don't forget" };
            for (int i = 0; i < newarray.Length; i++)
            {
                Console.WriteLine(newarray[i]);
            }
            Console.WriteLine(newarray.Max());
            Console.ReadKey();
        }

        static void increasevalue(out int value)
        {
            value = 5;
            value++;
        }


       /* static void show()
        {
            
            Encoding OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số thứ 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            Console.Write("Nhập số thứ 2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Số thứ 1: " + a + "Số thứ 2: " + b);
            Console.WriteLine("hi there" + sum("hi there", a, b));
            return;
        }

        public static int sum(string bla, int a, int b)
        {
            return a + b;
        }*/
    }
}
