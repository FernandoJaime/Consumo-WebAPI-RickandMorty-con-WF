using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickandMorty.Models
{
    public class Characters
    {
        // La lista de character se llama results ya que es el nombre que tiene en el JSON de la API.
        public List<Character>? results { get; set; } = new List<Character>();
        public Info info { get; set; }
    }
}
