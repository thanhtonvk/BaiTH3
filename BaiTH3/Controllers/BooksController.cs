using BaiTH3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BaiTH3.Controllers
{
    public class BooksController : ApiController
    {
        List<Book> bookList = new List<Book>()
        {
            new Book(){Id=1,TenSach="Them mot la dau",TacGia="HKT",NXB="HKT",NamXB=2021},
            new Book(){Id=2,TenSach="Them mot la dau1",TacGia="HKT",NXB="HKT",NamXB=2021},
            new Book(){Id=3,TenSach="Them mot la dau2",TacGia="HKT",NXB="HKT",NamXB=2021},
            new Book(){Id=4,TenSach="Them mot la dau3",TacGia="HKT",NXB="HKT",NamXB=2001},
            new Book(){Id=5,TenSach="Them mot la dau4",TacGia="HKT",NXB="HKT",NamXB=2021},

        };
        [HttpGet]
        [Route("books/{tensach}")]
        public Book GetSach_TenSach(string tensach) {
            return bookList.FirstOrDefault(x => x.TenSach == tensach);
        }
        [HttpGet]
        [Route("books/tenNV/sdt")]
        public IEnumerable<Book> GetSach_TenTacGia(string tacgia)
        {
            return bookList.Where(x => x.TacGia == tacgia);
        }
        [HttpGet]
        [Route("books/tenNV/gt/sdt")]
        public IEnumerable<Book> GetSach_NhaXB(string nxb)
        {
            return bookList.Where(x => x.NXB == nxb);
        }
        [HttpGet]
        [Route("books/getsach5nam")]
        public IEnumerable<Book> GetSach_5Nam()
        {
            return bookList.Where(x => x.NamXB - 2022 <= 5);
        }
    }
}
