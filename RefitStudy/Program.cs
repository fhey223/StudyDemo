using Nito.AsyncEx;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefitStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = AsyncContext.Run(() => new Program().GetBookAsync(17604305));
        }

        public async Task<string> GetBookAsync(int id)
        {
            var bookApi = RestService.For<IDoubanBook>("https://api.douban.com");

            return await bookApi.GetBook(id);
        }
    }
}
