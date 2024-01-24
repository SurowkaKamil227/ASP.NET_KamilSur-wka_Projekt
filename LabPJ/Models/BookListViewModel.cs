using System.Collections.Generic;
using LabPJ.Models;
namespace LabPJ.Models
{
    public class BookListViewModel
    {
        public PageInfo PageInfo { get; set; }
        public List<Book> Books { get; set; }
    }

    public class PageInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (int)System.Math.Ceiling((decimal)TotalItems / ItemsPerPage);
    }
}