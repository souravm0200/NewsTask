using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class NewsRepo
    {
        private static readonly NewsTaskDBContext Context;

        static NewsRepo()
        {
            Context = new NewsTaskDBContext();
        }

        public static IEnumerable<News> GetAllNews()
        {
            return Context.News.ToList();
        }
    }
}
