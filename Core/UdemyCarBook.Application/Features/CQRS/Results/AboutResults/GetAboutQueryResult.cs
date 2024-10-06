using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.CQRS.Results.AboutResults
{
    public class GetAboutQueryResult
    {  //About sınıfında listeleme yaparken gelmesini istediğim bütün sınıflar buraya geçirdim  a
        public int AboutID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        //a


    }
}
