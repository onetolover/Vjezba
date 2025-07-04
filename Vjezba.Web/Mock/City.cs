using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Vjezba.Web.Mock
{
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [JsonIgnore] // Evita serializar os clientes associados à cidade
        public ICollection<Client>? Clients { get; set; }
    }
}
