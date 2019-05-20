using System;
using System.Collections.Generic;
using System.Text;

namespace NeoNet.Domain.Commands
{
    public class CustomerCommand
    {

        public Guid Id { get; protected set; }

        public string Name { get; protected set; }

        public string Email { get; protected set; }

        public string Password { get; protected set; }
    }
}
