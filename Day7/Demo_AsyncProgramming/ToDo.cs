using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_AsyncProgramming
{
    class ToDo
    {
        public async Task<string> GetDataAsync()
        {
            HttpClient httpClient = new HttpClient();
            Uri apiAddr = new Uri("https://jsonplaceholder.typicode.com/posts");
            var result = await httpClient.GetAsync(apiAddr);
            if (result.IsSuccessStatusCode)
            {
                var data = await result.Content.ReadAsStringAsync();
                return data;
            }
            else
            {
                return null;
            }
        }
    }
}
