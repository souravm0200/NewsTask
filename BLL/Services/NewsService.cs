using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repo;
using DAL.Models;

namespace BLL.Services
{
    public  class NewsService
    {
        public static List<NewsDTO> GetAllNews()
        {
            var data = NewsRepo.GetAllNews();
            return NewsConverter(data);
        }

        private static List<NewsDTO> NewsConverter(IEnumerable<News> data)
        {
           
            throw new NotImplementedException();
        }
    }
}
