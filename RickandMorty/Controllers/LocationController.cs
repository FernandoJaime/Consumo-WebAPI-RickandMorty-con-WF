using RickandMorty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RickandMorty.Controllers
{
    public class LocationController
    {
        // Declaro una variable privada de tipo HttpClient.
        private HttpClient client;

        public LocationController()
        {
            client = new HttpClient();
        }

        // Metodo que devuelve todo la info de la locacion del character.
        public async Task<Location> GetForCharacter(Character pejota)
        {
            try
            {
                Location location = new Location();
                HttpResponseMessage response = await client.GetAsync(pejota.location.url);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    location = JsonSerializer.Deserialize<Location>(content);
                    return location;
                }
                else
                {
                    Console.WriteLine("Error al obtener los datos. Código de estado: " + response.StatusCode);
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error inesperado: " + e.Message);
                return null;
            }
        }
    }
}
