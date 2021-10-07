using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomial
{

    class Polynomial
    {
        //10x^0-1x^5+2x^3-3x^2+4x^1
        //0x^0+10x^5+4x^2+4x^1+6x^6
        //10x^0+4x^1-3x^2+2x^3-1x^5
        //-1x^0+4x^1-2x^3-7x^9+8x^8
        private double[] polynom;
        private int PolynomSize { get; set; }
        public Polynomial(int polynomSize)
        {
            PolynomSize = polynomSize;
            polynom = new double[PolynomSize];
        }
        public Polynomial()
        {
            Parse();
        }
        private void FindPolynomSize(string polinomial) {
            string temp = polinomial;
            int s;
            int i = 0;
            int[] arrPover = new int[100];
            while (temp != "")
            {
               
                s = (temp.IndexOf('^'));
                char pover = temp[s + 1];
                arrPover[i] = Convert.ToInt32(new string(temp[s + 1], 1));
                temp = temp.Remove(0, s + 2);
                i++;
            }
            int maxPover = arrPover[0];
            for (int j = 1; j < i; j++)
            {
                if (maxPover < arrPover[j]) maxPover = arrPover[j];
            }
            PolynomSize = maxPover+1;
        }

        private void Parse()
        {
            Console.Write("Enter polinom = ");
            string polinomial = Console.ReadLine();
            FindPolynomSize(polinomial);
            int s;
            int i = 0;
            int index;
            polynom = new double[PolynomSize];
            while (polinomial != "")
            {
                s = (polinomial.IndexOf('^'));
                char pover = polinomial[s + 1];
                index= Convert.ToInt32(new string(polinomial[s + 1], 1));
                string temp=polinomial.Substring(0, s - 1);
                polynom[index] = Convert.ToInt32(temp);
                polinomial = polinomial.Remove(0, s + 2);
            }

        }

        public void AppendPolynom()
        {
            for (int i = 0; i < PolynomSize; i++)
            {
                int m;
                double c;
                Console.Write("Enter the order of the polynomial -");
                m = int.Parse(Console.ReadLine());
                Console.Write("Enter the actual ratio -");
                c = int.Parse(Console.ReadLine());
                polynom[m] = c;
            }
            Console.Write("");
        }
        public override string ToString()
        {
            string std = "";
            for (int i = 0; i < PolynomSize; i++)
            {
                if (polynom[i] == 0) continue;
                if (i!=0&&polynom[i] > 0) std +="+";
                
                std += $"{polynom[i]}x^{i}";
            }
            return std;
        }
        public void Addition(Polynomial p)
        {
            int tempSize = this.PolynomSize;
            if (this.PolynomSize < p.PolynomSize) tempSize = p.PolynomSize;
            Polynomial temp = new Polynomial(tempSize);
            bool size = true;
            for (int i = 0; i < tempSize; i++)
            {

                if (i > this.PolynomSize || i == this.PolynomSize) { temp.polynom[i] = p.polynom[i]; size = false; }
                if(i > p.PolynomSize|| i == p.PolynomSize) {temp.polynom[i] = this.polynom[i]; size = false; }

                if(size)temp.polynom[i]= this.polynom[i] + p.polynom[i];
            }
            this.PolynomSize = temp.PolynomSize;
            this.polynom = temp.polynom;
        }

        public void Subtraction(Polynomial p)
        {
            int tempSize = this.PolynomSize;
            if (this.PolynomSize < p.PolynomSize) tempSize = p.PolynomSize;
            Polynomial temp = new Polynomial(tempSize);
            bool size = true;
            for (int i = 0; i < tempSize; i++)
            {

                if (i > this.PolynomSize || i == this.PolynomSize) { temp.polynom[i] = -p.polynom[i]; size = false; }
                if (i > p.PolynomSize || i == p.PolynomSize) { temp.polynom[i] = -this.polynom[i]; size = false; }

                if (size) temp.polynom[i] = this.polynom[i] - p.polynom[i];
            }
            this.PolynomSize = temp.PolynomSize;
            this.polynom = temp.polynom;
        }

        public void Multiplication(Polynomial p)
        {
            int tempSize = this.PolynomSize;
            if (this.PolynomSize < p.PolynomSize) tempSize = p.PolynomSize;
            Polynomial temp = new Polynomial(tempSize);
            bool size = true;
            for (int i = 0; i < tempSize; i++)
            {
                
                if (i > this.PolynomSize || i == this.PolynomSize) { temp.polynom[i] = 0; size = false; }
                if (i > p.PolynomSize || i == p.PolynomSize) { temp.polynom[i] = 0; size = false; }
                if(size)if (this.polynom[i] == 0 || p.polynom[i] == 0) temp.polynom[i] = 0;
                if (size) temp.polynom[i] = this.polynom[i] * p.polynom[i];
            }
            this.PolynomSize = temp.PolynomSize;
            this.polynom = temp.polynom;
        }

    }
}
