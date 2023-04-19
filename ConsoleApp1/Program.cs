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
       // st.Learn("ABC");
       Console.WriteLine(st.Name);



        //phan so`
        // Fraction ps1 = new Fraction();
        // ps1.NhapPhanSo();
        //Console.Write("Phan so thu nhat la: ");
        //ps1.InPhanSo();

        //Fraction ps2 = new Fraction();
        //ps2.NhapPhanSo();
        //Console.Write("Phan so thu hai la: ");
        //ps2.InPhanSo();

        //// Console.WriteLine("==========================");

        //Console.Write("Tong hai phan so la: ");
        //Fraction ps3 = Fraction.Add(ps1, ps2);
        //.InPhanSo();

        // Console.Write("Hieu hai phan so la: ");
        //Fraction ps4 = Fraction.Sub(ps1, ps2);
        //ps4.InPhanSo();

        // Console.Write("Tich hai phan so la: ");
        //Fraction ps5 = Fraction.Mul(ps1, ps2);
        //ps5.InPhanSo();

        // Console.Write("Thuong hai phan so la: ");
        //Fraction ps6 = Fraction.Div(ps1, ps2);
        //ps6.InPhanSo();


        //tien dien
        //VietNam vn = new VietNam("T2207A","Phung Van Vu ","17/4/2004","Sinh Vien ", 15,"Vietnam" ) ;
        //vn.HienThi();
         
        //human
        Human h = new Human();
        Human h2 = new Human() { Telephone = "000000" };
        h.family[0] = " Phung Van Vu";
        Console.WriteLine(h.family[0]);

        h2[0] = " Vu Phung Van";

        List<string> strs = new List<string>();
        strs.Add("Hello");
        Console.WriteLine(strs[0]);

        //phone
        Phone phonebook = new PhoneBoock();
        phonebook.insertPhone("John", "123456789");
        phonebook.insertPhone("Jane", "987654321");
        phonebook.SearchPhone("John");
        phonebook.UpdatePhone("Jane", "111111111");
        phonebook.RemovePhone("John");
        phonebook.Sort();

        //tiendien2


        Console.Write("Nhap so luong khach hang Viet Nam: ");
        int soLuongKHVN = int.Parse(Console.ReadLine());

        List<KhachHangVietNam> dsKHVN = new List<KhachHangVietNam>();

        KhachHangVietNam khVN = new KhachHangVietNam();

        for (int i = 0; i < soLuongKHVN; i++)
        {
            Console.WriteLine("\nNhap thong tin khach hang Viet Nam ");
            Console.Write("Nhap ma khach hang: ");
            khVN.MaKH = Console.ReadLine();

            Console.Write("Nhap ho ten khach hang: ");
            khVN.HoTen = Console.ReadLine();

            Console.Write("Nhap ngay ra hoa don: ");
            khVN.NgayRaHD = Console.ReadLine();

            Console.Write("Nhap doi tuong khach hang (sinh hoat, kinh doanh, san xuat): ");
            khVN.DoiTuongH = Console.ReadLine();

            Console.Write("Nhap so luong (so KW tieu thu): ");
            khVN.SoLuong = int.Parse(Console.ReadLine());

            dsKHVN.Add(khVN);
        }

        Console.Write("\nNhap so luong khach hang nuoc ngoai: ");
        int soLuongKHNN = int.Parse(Console.ReadLine());

        List<KhachHangNuocNgoai> dsKHNN = new List<KhachHangNuocNgoai>();

        KhachHangNuocNgoai khNN = new KhachHangNuocNgoai();

        for (int i = 0; i < soLuongKHNN; i++)
        {
            Console.WriteLine("\nNhap thong tin khach hang nuoc ngoai");
            Console.Write("Nhap ma khach hang: ");
            khNN.MaKH = Console.ReadLine();

            Console.Write("Nhap ho ten khach hang: ");
            khNN.HoTen = Console.ReadLine();

            Console.Write("Nhap ngay ra hoa don: ");
            khNN.NgayRaHD = Console.ReadLine();

            Console.Write("Nhap quoc tich: ");
            khNN.QuocTich = Console.ReadLine();

            Console.Write("Nhap so luong: ");
            khNN.SoLuong = int.Parse(Console.ReadLine());

            dsKHNN.Add(khNN);
        }

        Console.WriteLine("\n======================================");
        Console.WriteLine("\nDanh sach khach hang va thanh tien:");

        Console.WriteLine("\nKhach hang Viet Nam:");
        for (int i = 0; i < soLuongKHVN; i++)
        {
            Console.WriteLine("Ma KH: " + khVN.maKH + ", ten KH: " + khVN.hoTen + ", ngay ra HD: " + khVN.ngayRaHD + ", so luong: " + khVN.soLuong + ", thanh tien: " + khVN.TinhThanhTien());
        }

        Console.WriteLine("\nKhach hang nuoc ngoai:");
        for (int i = 0; i < soLuongKHNN; i++)
        {
            Console.WriteLine("Ma KH: " + khNN.maKH + ", ten KH: " + khNN.hoTen + ", ngay ra HD: " + khNN.ngayRaHD + ", quoc tich: " + khNN.quocTich + ", so luong: " + khNN.soLuong + ", don gia: " + khNN.donGia + ", thanh tien: " + khNN.TinhThanhTien());
        }
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
