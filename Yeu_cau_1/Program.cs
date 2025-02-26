using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeu_cau_1
{
    public class GiangVien
    {
        public string Maso { get; set; }
        public string Hoten { get; set; }
        public string Namsinh { get; set; }
        //Phương thức khởi tạo không có tham số
        public GiangVien()
        {

        }
        //Phương thức khởi tạo có tham số 
        public GiangVien(string maso, string hoten, int namsinh)
        {
            maso = maso;
            hoten = hoten;
            namsinh = namsinh;
        }
        //Phương thức nhập thông tin của giảng viên từ bàn phím
        public virtual void Nhap()
        {
            Console.Write("Nhấp mã số giảng viên: ");
            Console.ReadLine();
            Console.Write("Nhập họ tên của giảng viên: ");
            Console.ReadLine();
            Console.Write("Nhập năm sinh của giảng viên: ");
            namsinh = int.Parse(Console.ReadLine());
        }
        //Tính lương trả về giá trị 0
        public virtual int TinhLuong()
        {
            return 0;
        }
        public class GiangVienCH : GiangVien
        {
            public float hesoluong { get; set; }

            public GiangVienCH() { }

            public GiangVienCH(string maso, string hoten, int namsinh, float hesoluong)
                : base(maso, hoten, namsinh)
            {
                hesoluong = hesoluong;
            }

            public override void Nhap()
            {
                base.Nhap();
                Console.Write("Nhập hệ số lương: ");
                hesoluong = float.Parse(Console.ReadLine());
            }

            public override int linhluon()
            {
                return (int)(hesoluong * 2340000);
            }

            public override void xuat()
            {
                base.xuat();
                Console.WriteLine($"Hệ số lương: {hesoluong}, Lương: {tinhluong()}");
            }
        }
        public class giangVienCH : GiangVien
        {
            public float Hesoluong { get; set; }

            public giangVienCH() { }

            public giangVienCH(string maso, string hoten, int namsinh, float hesoluong)
                : base(maso, hoten, namsinh)
            {
                Hesoluong = hesoluong;
            }

            public override void Nhap()
            {
                base.Nhap();
                Console.Write("Nhập hệ số lương: ");
                Hesoluong = float.Parse(Console.ReadLine());
            }

            public override int TinhLuong()
            {
                return (int)(Hesoluong * 2340000);
            }

            public override void xuat()
            {
                base.xuat();
                Console.WriteLine($"Hệ số lương: {Hesoluong}, Lương: {TinhLuong()}");
            }
            public class GiangVienCH : GiangVien
            {
                public float Hesoluong { get; set; }

                public GiangVienCH() { }

                public GiangVienCH(string maso, string hoten, int namsinh, float hesoluong)
                    : base(maso, hoten, namsinh)
                {
                    Hesoluong = hesoluong;
                }

                public override void Nhap()
                {
                    base.Nhap();
                    Console.Write("Nhập hệ số lương: ");
                    Hesoluong = float.Parse(Console.ReadLine());
                }

                public override int TinhLuong()
                {
                    return (int)(Hesoluong * 2340000);
                }

                public override void xuat()
                {
                    base.xuat();
                    Console.WriteLine($"Hệ số lương: {Hesoluong}, Lương: {TinhLuong()}");
                }
                public class giangVienCH : GiangVien
                {
                    public float Hesoluong { get; set; }

                    public giangVienCH() { }

                    public giangVienCH(string maso, string hoten, int namsinh, float hesoluong)
                        : base(maso, hoten, namsinh)
                    {
                        Hesoluong = hesoluong;
                    }

                    public override void Nhap()
                    {
                        base.Nhap();
                        Console.Write("Nhập hệ số lương: ");
                        Hesoluong = float.Parse(Console.ReadLine());
                    }

                    public override int TinhLuong()
                    {
                        return (int)(Hesoluong * 2340000);
                    }

                    public override void xuat()
                    {
                        base.xuat();
                        Console.WriteLine($"Hệ số lương: {Hesoluong}, Lương: {TinhLuong()}");
                    }
                }
            }
        }
    }
}
