namespace oop
{
    class Complex
    {
        public double n, m;
        public Complex sum(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.n = a.n + b.n;
            res.m = a.m + b.m;
            return res;
        }

        public void Print(Complex a)
        {
            Console.WriteLine("{0} + {1}i", a.n, a.m);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a 1-го комплексного числа: ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b 1-го комплексного числа: ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите a 2-го  комплексного числа: ");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b 2-го комплексного числа: ");
            double b2 = Convert.ToDouble(Console.ReadLine());
            
            Complex c1 = new Complex();
            Complex c2 = new Complex();
            c1.n = a1;
            c1.m = b1;
            c2.n = a2;
            c2.m = b2;

            Console.WriteLine("Введенные комплексные числа: ");
            c1.Print(c1);
            c2.Print(c2);

            Console.WriteLine("Ответ: {0} + {1}i", c1.sum(c1, c2).n, c1.sum(c1, c2).m);
        }
    }
}