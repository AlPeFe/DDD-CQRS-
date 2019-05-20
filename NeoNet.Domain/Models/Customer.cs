using NeoNet.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeoNet.Domain.Models
{
    //esta clase es de BBDD, es el objeto de la entidad, 
    //se crea un constructor con getters y setters privados para no entrar en conflicto con el diseño DDD
    public class Customer : Entity
    {
      
        public Customer(Guid id, string name, string email, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
        }

        protected Customer() { }

        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }


    }
}
