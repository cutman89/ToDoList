using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class ViewModelTest
    {
        
        public async Task Search()
        {
            using var client = new HttpClient();

            var result = await client.GetAsync("http://webcode.me");
            Console.WriteLine(result.StatusCode);
        }
    }
}
