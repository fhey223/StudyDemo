using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefitStudy
{
    public interface IDoubanBook
    {
        [Get("/v2/book/{id}")]
        Task<string> GetBook(int id);
    }
}
