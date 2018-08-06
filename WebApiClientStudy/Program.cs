using Nito.AsyncEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiClient;

namespace WebApiClientTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = AsyncContext.Run(() => new Program().GetBookAsync(17604305));

        }

        public async Task<string> GetBookAsync(int id)
        {
            //var config = new HttpApiConfig
            //{
            //    // 请求的域名，会覆盖[HttpHost]特性
            //    HttpHost = new Uri("https://api.douban.com"),
            //};
            //var client = HttpApiClient.Create<IDoubanBook>(config);

            var api = HttpApiClient.Create<IDoubanBook>();
            var book = await api.GetBook(17604305);
            return book;
        }
    }
}
