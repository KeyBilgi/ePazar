using Core.Entityes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utils
{
    public static class Api<T> where T: IEntity, new()
    {
        public static async Task<T> MakeWebRequest(string url, Expression<Func<IEntity, bool>> filter = null)
        {
            HttpClient client = new HttpClient();
            var result = client.GetAsync(url).Result;

            if (result.IsSuccessStatusCode)
            {
                string sonuc = await result.Content.ReadAsStringAsync();
                var entity = JsonConvert.DeserializeObject<T>(sonuc);
                return entity;
            }
            return new T();
        }
    }
}
