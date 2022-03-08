using BaiTH3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BaiTH3.Controllers
{
    public class NhanViensController : ApiController
    {
        List<NhanVien> nhanVienList = new List<NhanVien>()
        {
            new NhanVien(){Id = 1,TenNV="Diep",GioiTinh="Nu",SDT="021654633"},
            new NhanVien(){Id = 2,TenNV="Ton",GioiTinh="Nu",SDT="021654633"},
            new NhanVien(){Id = 3,TenNV="Quang",GioiTinh="Nu",SDT="021654633"},
            new NhanVien(){Id = 4,TenNV="Cuong",GioiTinh="Nu",SDT="021654633"},
            new NhanVien(){Id = 5,TenNV="Hihi",GioiTinh="Nu",SDT="021654633"},
        };
        [HttpGet]
        [Route("api/nhanviens/{tenNV}")]
        public NhanVien getNhanVien_TenNV(string tenNV)
        {
            var model = nhanVienList.FirstOrDefault(x => x.TenNV == tenNV);
            return model;
        }
        [HttpGet]
        [Route("api/nhanviens/{tenNV}/{sdt}")]
        public NhanVien getNhanVien_TenNV_SDT(string tenNV,string sdt)
        {
            var model = nhanVienList.FirstOrDefault(x => x.TenNV == tenNV&&x.SDT==sdt);
            return model;
        }
        [HttpGet]
        [Route("api/nhanviens/{tenNV}/{sdt}/{gt}")]
        public NhanVien getNhanVien_TenNV_SDT_GT(string tenNV, string sdt,string gt)
        {
            var model = nhanVienList.FirstOrDefault(x => x.TenNV == tenNV && x.SDT == sdt&&x.GioiTinh==gt);
            return model;
        }
        [HttpPut]
        [Route("api/nhanviens/putnhanvien")]
        public IEnumerable<NhanVien> PutNhanVien([FromUri] NhanVien nhanVien)
        {
            var model = nhanVienList.FirstOrDefault(x => x.Id == nhanVien.Id);
            nhanVienList.Remove(model);
            nhanVienList.Add(nhanVien);
            return nhanVienList;
        }

    }
}
