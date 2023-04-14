using System.Collections.Generic;
using T2207A;


public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Hello World");// print
        int x = 10;
        string s = " T2207A";
        double pi = 3.12159;
        if (x > 5)
        {
            x--;

        }
        else
        {
            x++;
        }
        int[] arr = new int[5];
        arr[0] = 1;
        arr[1] = 22;
        arr[2] = 27;
        arr[3] = 17;
        arr[4] = 55;

        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }

        string cmd = Console.ReadLine();
        Console.WriteLine(" Chuoi vua nhap : " + cmd);
        string cmd2 = Console.ReadLine();
        int n = Convert.ToInt32(cmd2);
        Console.WriteLine(" So vua nhap : " + n);
        if (IsPrime(n))
        {
            Console.WriteLine(n + " la so nguyen to ");
        }
        List<int> ints = new List<int>();
        ints.Add(4);
        ints.Add(19);
        ints.Add(27);

        Student st = new Student();
        // st.Run();
        // st.Learn();
        //phan so`
        Fraction ps1 = new Fraction();
        ps1.NhapPhanSo();
        Console.Write("Phan so thu nhat la: ");
        ps1.InPhanSo();

        Fraction ps2 = new Fraction();
        ps2.NhapPhanSo();
        Console.Write("Phan so thu hai la: ");
        ps2.InPhanSo();

        Console.WriteLine("==========================");

        Console.Write("Tong hai phan so la: ");
        Fraction ps3 = Fraction.Add(ps1, ps2);
        ps3.InPhanSo();

        Console.Write("Hieu hai phan so la: ");
        Fraction ps4 = Fraction.Sub(ps1, ps2);
        ps4.InPhanSo();

        Console.Write("Tich hai phan so la: ");
        Fraction ps5 = Fraction.Mul(ps1, ps2);
        ps5.InPhanSo();

        Console.Write("Thuong hai phan so la: ");
        Fraction ps6 = Fraction.Div(ps1, ps2);
        ps6.InPhanSo();


    }

        //Console.WriteLine(" nhập 1 số xem nó là số nguyên tố hay không ");
        // string snt = Console.ReadLine();
        //int m = Convert.ToInt32 (snt);
        public static bool IsPrime(int n)
        {
            if (n < 2)return false;
            if (n < 2) return false;

            for (int i = 2; i <= n/2; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
