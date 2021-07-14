using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    class TB
    {
        protected internal string maSP { get; set; }
        protected internal string tenSP { get; set; }
        protected internal string noiSX { get; set; }
        protected internal int dungTich { get; set; }
        protected internal int dungLuong { get; set; }
        protected internal bool inverter { get; set; }
        protected internal bool khumui { get; set; }
        protected internal bool khangkhuan { get; set; }
        protected internal int soLuong { get; set; }
        protected internal int giaBan { get; set; }

        public virtual void getInfo()
        {
            var tab = new StringBuilder();
            tab.Append(' ', 5);
            Console.WriteLine(this.maSP);
            Console.WriteLine(this.tenSP);
            Console.WriteLine(this.noiSX);
            Console.WriteLine(this.soLuong);
            Console.WriteLine(this.giaBan);
        }
    }

    
}
