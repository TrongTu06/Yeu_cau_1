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
        class GiangVienCH : GiangVien
        {
            private float hesoluong;
            public GiangVienCH() : base()
            {
                hesoluong = 0;
            }
            public GiangVienCH (string maso, string hoten, int namsinh, float hesoluong): base(maso, hoten, namsinh)
            {
                this.hesoluong = hesoluong;
            }
            public float hesoluon
            {
                get { return hesoluong; }
                set { hesoluong = value; }
            }
            public override void Nhap()
            {
                base.Nhap();
                Console.Write("Nhập hệ số lương");
                hesoluong = float.Parse(Console.ReadLine());
            }
            public override int Tinhluong()
            {
                return (int)(hesoluong * 23400200);
            }
            class giangviengtg : GiangVien
            {
                sotietday = 0;
            }
            public giangviengtg(string maso, string hoten, int namsinh, int sotietday)
            {
                this.sotietday = sotietday;
            }
            public override void nhap()
            {
                base.Nhap();
                Console.WriteLine("Nhập số tiết dạy:");
                sotietday = int.Parse(Console.ReadLine());
            }
            public override int TinhLuong()
            {
            }
        }
    }
}
