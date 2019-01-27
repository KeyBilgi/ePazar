using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.Congrete
{
    public class User : Core.Entityes.IEntity
    {
        public int id { get; set; }
        public string kod { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string adres { get; set; }
        public string phonenumber { get; set; }
        public bool medenihal { get; set; }
        public bool cinsiyet { get; set; }
        public int firmaid { get; set; }
        public string egitimdurum { get; set; }
    }
}
