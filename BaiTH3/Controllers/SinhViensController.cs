using BaiTH3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BaiTH3.Controllers
{
    public class SinhViensController : ApiController
    {
        List<SinhVien> sinhVienList = new List<SinhVien>()
        {
                    new SinhVien(){Id=1,TenSV="Do thanh ton",DiaChi="Hung Yen",NamSinh=2001},
                    new SinhVien(){Id=2,TenSV="Do thanh ton",DiaChi="Hung Yen",NamSinh=2001},
                    new SinhVien(){Id=3,TenSV="Do thanh ton",DiaChi="Hung Yen",NamSinh=2001},
                    new SinhVien(){Id=4,TenSV="Do thanh ton",DiaChi="Hung Yen",NamSinh=2001},

        };
        [HttpGet]
        [Route("api/sinhviens/{diachi}")]
        public IEnumerable<SinhVien> getSinhVien_DiaChi(string diachi)
        {
            return sinhVienList.Where(x => x.DiaChi == diachi);
        }
        [HttpGet]
        [Route("api/sinhviens/{tensv}")]
        public IEnumerable<SinhVien> getSinhVien_TenSV(string tensv)
        {
            return sinhVienList.Where(x => x.TenSV == tensv);
        }
        [HttpGet]
        [Route("api/sinhviens/sinhvientren20")]
        public IEnumerable<SinhVien> getSinhVien_20tuoi()
        {
            var year = DateTime.Now.Year;
            return sinhVienList.Where(x => year - x.NamSinh >=20);
        }

    }
}
