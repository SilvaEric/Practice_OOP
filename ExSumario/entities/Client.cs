using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExSumario.entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client(){

        }
        public Client(string name, string email, DateTime birthDate){
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString(){
            StringBuilder Csb = new StringBuilder();
            Csb.Append($"{Name} ({BirthDate}) - {Email}");
            return Csb.ToString();
        }
    }
}