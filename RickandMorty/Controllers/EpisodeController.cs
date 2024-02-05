using RickandMorty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RickandMorty.Controllers
{
    public class EpisodeController
    {
        private HttpClient client;

        public EpisodeController()
        {
            client = new HttpClient();
        }

        // Metodo que regresa todos los episodios.
        public async Task<Episodes> GetAll()
        {
            try
            {
                Episodes episodes = new Episodes();
                HttpResponseMessage response = await client.GetAsync("https://rickandmortyapi.com/api/episode");
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    episodes = JsonSerializer.Deserialize<Episodes>(content);
                    return episodes;
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

        // Metodo que regresa todos los episodios de un personaje.
        public async Task<Episode> GetForCharacter(string url) 
        {
            try
            {
                Episode episode = new Episode();
                
                // url porque los characters tienen una lista de episodios que son urls.
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    episode = JsonSerializer.Deserialize<Episode>(content);
                    return episode;
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