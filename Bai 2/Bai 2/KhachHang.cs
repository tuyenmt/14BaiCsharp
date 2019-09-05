﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    class KhachHang
    {
        private string code;
        private string name;
        private string address;
        private int deposits;
        private string dateTime;
        private int month;
        private bool loai;
        public KhachHang()
        {

        }
        public KhachHang(string code, string name, string address, int deposits, string dateTime, int month, bool loai)
        {
            this.code = code;
            this.name = name;
            this.address = address;
            this.deposits = deposits;
            this.dateTime = dateTime;
            this.month = month;
            this.loai = loai;
        }
        

        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public int Deposits { get => deposits; set => deposits = value; }
        public string DateTime { get => dateTime; set => dateTime = value; }
        public int Month { get => month; set => month = value; }
        public bool Loai { get => loai; set => loai = value; }

        public override string ToString()
        {
            string s = Code + " | " + Name + " | " + Address + " | " + Deposits + " | " + DateTime + " | " + Month +
                " | " + tienLai();
            return s;
        }
        public double tienLai()
        {
            double tienLai = 0.0;
            if (loai == false)
            {
                if (Month == 1)
                {
                    tienLai = (Deposits * 0.06) / 12;
                }
                else if (Month == 3)
                {
                    tienLai = ((Deposits * 0.07) / 12) * 3;
                }
                else if (Month == 6)
                {
                    tienLai = ((Deposits * 0.08) / 12) * 6;
                }
                else if (Month == 12)
                {
                    tienLai = ((Deposits * 0.09));
                }
            }
            else if (loai == true)
            {
                if (Month == 1)
                {
                    tienLai = (Deposits * 0.07) / 12;
                }
                else if (Month == 3)
                {
                    tienLai = ((Deposits * 0.08) / 12) * 3;
                }
                else if (Month == 6)
                {
                    tienLai = ((Deposits * 0.09) / 12) * 6;
                }
                else if (Month == 12)
                {
                    tienLai = ((Deposits * 0.1));
                }
            }
            return tienLai;
        }
    }
}
