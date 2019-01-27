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
        string sonuc;
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
        public string GetFromServer(string url, Expression<Func<User, bool>> filter = null)
        {
            Blt0101Users user = new Blt0101Users();            
            WebRequest request = WebRequest.Create(url);
            request.Method = "GET";
            request.Credentials = CredentialCache.DefaultCredentials;
            request.GetResponseAsync();
            
            return null;
        }

        public List<User> GetList(Expression<Func<User, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
        public async Task<List<IEntity>> GetListFromServer(string url, Expression<Func<IEntity, bool>> filter = null)
        {
            List<IEntity> list = new List<IEntity>();
            HttpClient client = new HttpClient();
            var result = client.GetAsync(url).Result;
            if (result.IsSuccessStatusCode)
            {
                string sonuc = await result.Content.ReadAsStringAsync();
                list = JsonConvert.DeserializeObject<List<IEntity>>(sonuc);
            }
            return list;
        }
        //public async Task<IEntity> GetFromServer(string url, Expression<Func<IEntity, bool>> filter = null)
        //{
        //    HttpClient client = new HttpClient();
        //    var result = client.GetAsync(url).Result;
            
        //    if (result.IsSuccessStatusCode)
        //    {
        //        string sonuc = await result.Content.ReadAsStringAsync();
        //        var entity = JsonConvert.DeserializeObject<IEntity>(sonuc);
        //        return entity;
        //    }
        //    return null;
        //}
        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
