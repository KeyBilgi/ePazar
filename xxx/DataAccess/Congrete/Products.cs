using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using Entities.Congrete;
using Core.Entityes;
using System.Linq.Expressions;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DataAccess.Congrete
{
    public class Products : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetList(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> GetListFromServer(string url, Expression<Func<Product, bool>> filter = null)
        {
            List<Entities.Congrete.Product> list = new List<Entities.Congrete.Product>();
            HttpClient client = new HttpClient();
            var result = client.GetAsync(url).Result;
            if (result.IsSuccessStatusCode)
            {
                string sonuc = await result.Content.ReadAsStringAsync();
                list = JsonConvert.DeserializeObject<List<Product>>(sonuc);
            }
            return list;
        }

    }
}
