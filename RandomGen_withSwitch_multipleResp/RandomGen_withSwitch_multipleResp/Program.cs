using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGen_withSwitch_multipleResp
{
    class Program
    {
        static void Main(string[] args)
        {
            starting:
            Random RandomGen = new Random();

            int num1 = RandomGen.Next(100);
            int num2 = RandomGen.Next(100);
            int result;

            Console.WriteLine("{0} + {1}", num1, num2);
            result = Convert.ToInt32(Console.ReadLine());
            if (result == num1+num2)
            {
                int changeResponse= RandomGen.Next(4); //4 is needed and not 3 to show all results{1,2,3}
                switch(changeResponse)
                {
                    case 1: Console.WriteLine("Correct!"); break;
                    case 2: Console.WriteLine("Bravo!"); break;
                    case 3: Console.WriteLine("Well Done!"); break;
                
                }
            }

            else 
            {
                int changeResponse = RandomGen.Next(1, 4);
                switch (changeResponse)
                {
                    case 1: Console.WriteLine("Wrong!"); break;
                    case 2: Console.WriteLine("Try harder!"); break;
                    case 3: Console.WriteLine("Fantastic but wrong ans!"); break;

               }     
            }
            goto starting;
        }
    }
}
