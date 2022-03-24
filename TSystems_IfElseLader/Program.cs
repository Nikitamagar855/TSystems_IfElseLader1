using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystems_IfElseLader
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("PLEASE ENTER MARKS");
            int Marks = Convert.ToInt32(Console.ReadLine());

            if( (Marks < 0) || (Marks > 100))
            {
                Console.WriteLine("INVALID INPUT PLEASE ENTER MARKS BETWEENT 0 To 100");
            }
            else if((Marks >=0) && (Marks < 40))
            {
                Console.WriteLine( " SORRY YOuR FAIl.\n BETTER LUCK NEXT TIMR");
            }
            else if ((Marks == 40) && (Marks > 50))
            {
                Console.WriteLine("C");
            }
            else if((Marks==50) && (Marks > 60))
            {
                Console.WriteLine("B");
            }
            else if ((Marks == 60) && (Marks <75))
            {
                Console.WriteLine("A");
            }
            else if ((Marks == 75) && (Marks <94 ))
            {
                Console.WriteLine("A++");
            }
            else if (Marks > 95)
            {
                Console.WriteLine("OUT STANDING");
            }
            Console.ReadLine();
            goto start;
        }
    }
}
