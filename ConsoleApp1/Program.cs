using System.Collections.Generic;
using T2207A;


public class Program

{
    public static void Main(String[] args)
    {
        PhoneBook sdt = new PhoneBook();


        QuanLySinhVien quanLySinhVien = new QuanLySinhVien();
        int chucNang = 0;
        do
        {
            Console.WriteLine("Chon chuc nang:");
            Console.WriteLine("1. Them sinh vien");
            Console.WriteLine("2. Cap nhat thong tin sv boi ID");
            Console.WriteLine("3. Xoa sv boi ID");
            Console.WriteLine("4. Tim kiem sv theo ten");
            Console.WriteLine("5. Sap xep sv theo diem trung binh (GPA)");
            Console.WriteLine("6. Sap xep sv theo ten");
            Console.WriteLine("7. Sap xep sv theo ID");
            Console.WriteLine("8. Hien thi danh sach sv");
            Console.WriteLine("0. Thoat");
            Console.Write("Chon chuc nang: ");
            chucNang = int.Parse(Console.ReadLine());
            switch (chucNang)
            {
                case 1:
                    quanLySinhVien.ThemSinhVien();
                    break;
                case 2:
                    quanLySinhVien.CapNhatSinhVien();
                    break;
                case 3:
                    quanLySinhVien.XoaSinhVien();
                    break;
                case 4:
                    quanLySinhVien.TimKiemSinhVien();
                    break;
                case 5:
                    quanLySinhVien.SapXepTheoDiemTrungBinh();
                    break;
                case 6:
                    quanLySinhVien.SapXepTheoTen();
                    break;
                case 7:
                    quanLySinhVien.SapXepTheoID();
                    break;
                case 8:
                    quanLySinhVien.HienThiDanhSachSinhVien();
                    break;
                case 0:
                    Console.WriteLine("Ket thuc");
                    break;
                default:
                    Console.WriteLine("Chuc nang khong ton tai!");
                    break;
            }
            Console.WriteLine();
        } while (chucNang != 0);
    }
        // public static void Main1(String[] args)
        /// {
        //    Thread t = new Thread(DemoRun);  //Tham so phai la 1 function
        // luong chay ngam background, ket thuc khi cac luong khac ket thuc
        //  t.IsBackground = true;

        //Truyen trong start
        //  t.Start("Hello");
        //}

        // static void DemoRun(object o)
        // {
        //ep kieu string => string
        //  string s = (string)o;
        //  for (int i = 0; i < 200; i++)
        // {
        //     lock (o)
        //    {
        //        Console.WriteLine(s + " i = " + i);
        //    }

        //   try
        //   {
        //       Thread.Sleep(1000);
        //   }
        //   catch (Exception e)
        //   {

        //    }
        // }
        // }
        public static void Main2(String[] args)
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
        Phone phonebook = new PhoneBook();
        phonebook.InsertPhone("John", "123456789");
        phonebook.InsertPhone("Jane", "987654321");
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

        //Inews
        News news = new News();
        news.Id = 1;
        news.Title = "Hello World";
        news.PublishDate = "21-04-2023";
        news.Author = "Ngo Manh Son";
        news.Content = "This is an example news.";
        int[] rateList = { 3, 4, 5 };
        news.Calculate(rateList);
        news.Display();
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
