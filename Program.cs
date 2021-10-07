using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomial
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
Console.Write("Enter the maximum order of the polynomial - ");
int m1 = int.Parse(Console.ReadLine());
Polynomial p1 = new Polynomial(m1+1);
p1.AppendPolynom();
Console.WriteLine(p1.ToString());

Console.Write("Enter the maximum order of the polynomial - ");
int m2 = int.Parse(Console.ReadLine());
Polynomial p2 = new Polynomial(m2+1);
p2.AppendPolynom();
Console.WriteLine(p2.ToString());
p1.Addition(p2);
Console.WriteLine(p1.ToString());
p1.Subtraction(p2);
Console.WriteLine(p1.ToString());

Polynomial p3 = new Polynomial(3);
p3.AppendPolynom();
p1.Multiplication(p3);
Console.WriteLine(p1.ToString());

*/
            Polynomial p1 = new Polynomial();
            Console.WriteLine(p1.ToString());
            Polynomial p2 = new Polynomial();
            Console.WriteLine(p2.ToString());
            p1.Addition(p2);
            Console.WriteLine(p1.ToString());
            p1.Subtraction(p2);
            Console.WriteLine(p1.ToString());
            Polynomial p3= new Polynomial();
            Console.WriteLine(p3.ToString());
            p1.Multiplication(p3);
            Console.WriteLine(p1.ToString());
        }
    }
}
