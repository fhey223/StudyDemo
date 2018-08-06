using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiClient;
using WebApiClient.Attributes;

namespace WebApiClientTest
{
    [HttpHost("https://api.douban.com")]
    public interface IDoubanBook:IHttpApi
    {
        [HttpGet("/v2/book/{id}")]
        ITask<string> GetBook(int id);
    }
}
