using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTH3.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public string NXB { get; set; }
        public int NamXB { get; set; }
    }
}