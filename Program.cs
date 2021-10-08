using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 First task 
 < today is a
 wonderful day < I'm learning a new programming
 language < hello world > and I'm happy > the sun
 is shining >
*/

/*
 Third task
 Root folder - WebServers  | File name - myfile
 */
namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            // First task 
            string text = "# today is a\n wonderful day # I'm learning a new programming\n language # hello world # and I'm happy # the sun\n is shining #";
            WorkWithText1 t1 = new WorkWithText1(text);
            Console.WriteLine(t1);
            // Third task
            string text3 = @"c: \WebServers \home \testsite \www \myfile.txt";
            WorkWithText3 t3 = new WorkWithText3(text3);
            Console.WriteLine(t3);
        }
    }
}
