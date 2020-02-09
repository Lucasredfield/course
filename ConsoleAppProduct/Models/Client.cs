using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProduct.Models
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
        
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Nome: ");
            stringBuilder.AppendLine(Name);
            stringBuilder.Append("Email: ");
            stringBuilder.AppendLine(Email);
            stringBuilder.Append("BirthDate: ");
            stringBuilder.AppendLine(BirthDate.ToString("dd/MM/yyyy HH:mm:ss"));
            return stringBuilder.ToString();
        }

    }
}
