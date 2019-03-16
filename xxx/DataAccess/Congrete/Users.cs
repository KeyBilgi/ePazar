using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Entities.Congrete;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Core.Entityes;
using System.Net;

namespace DataAccess.Congrete
{
    public class Users<T> : Abstract.IUsersDal where T: class, IEntity
    {
        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public User Get(Expression<Func<User, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
        public List<User> GetList(Expression<Func<User, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
        //public async Task<T> GetListFromServer(string url, Expression<Func<IEntity, bool>> filter = null)
        //{
            //HttpClient client = new HttpClient();
            //var result = client.GetAsync(url).Result;
            //if (result.IsSuccessStatusCode)
            //{
            //    string sonuc = await result.Content.ReadAsStringAsync();
            //    var entity = JsonConvert.DeserializeObject<T>(sonuc);
            //    return entity;
            //}
            //return Core.Utils.Api<Blt0101Users>.MakeWebRequest("http://localhost:52474/api/user", null);
        //}
        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
