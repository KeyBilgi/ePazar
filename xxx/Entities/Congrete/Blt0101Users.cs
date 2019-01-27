using System;
using System.Collections.Generic;
using Core.Entityes;

namespace Entities.Congrete
{
    public partial class Blt0101Users : IEntity
    {
        public int Id { get; set; }
        public string Kod { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public string Phonenumber { get; set; }
        public bool? Cinsiyet { get; set; }
        public bool? Medenihal { get; set; }
        public int? Firmaid { get; set; }
        public string Egitimdurum { get; set; }
    }
}
