using RickandMorty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RickandMorty.Controllers
{
    public class CharacterController
    {
        // Declaro una variable privada de tipo HttpClient.
        private HttpClient client;

        public CharacterController()
        {
            client = new HttpClient();
        }

        // Metodo que regresa todos los characters de la 1er pagina.
        public async Task<Characters> GetAll()
        {
            try
            {
                Characters characters = new Characters();
                HttpResponseMessage response = await client.GetAsync("https://rickandmortyapi.com/api/character");
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();

                    // Deserializo el JSON a un objeto de tipo Characters.
                    characters = JsonSerializer.Deserialize<Characters>(content);
                    return characters;
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

        // Metodo que regresa todos los characters que apliquen los filtros.
        public async Task<Characters> GetForAllFilters(string valor1, string valor2, string valor3)
        {
            try
            {
                Characters characters = new Characters();
                HttpResponseMessage response = await client.GetAsync($"https://rickandmortyapi.com/api/character/?name={valor1}&status={valor2}&gender={valor3}");
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    characters = JsonSerializer.Deserialize<Characters>(content); // Deserializo.
                    return characters;
                }
                else if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    throw new Exception($"No existe personaje que coincida con este filtro aplicado.");
                }
                else
                {
                    throw new Exception("Error al obtener los datos. Código de estado: " + response.StatusCode);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // Metodo que regresa todos los characters de la next pagina.
        public async Task<Characters> GetNextPage(Characters personaje)
        {
            try
            {
                if (string.IsNullOrEmpty(personaje.info.next))
                {
                    throw new Exception("No existen mas paginas, estos son todos los personajes."); // No hay next page.
                }

                Characters characters = new Characters();
                HttpResponseMessage response = await client.GetAsync(personaje.info.next);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    characters = JsonSerializer.Deserialize<Characters>(content); // Deserializo.
                    return characters;
                }
                else
                {
                    throw new Exception("Error al obtener los datos. Código de estado: " + response.StatusCode);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // Metodo que regresa todos los characters de la prev pagina.
        public async Task<Characters> GetPrevPage(Characters personaje)
        {
            try
            {
                if (string.IsNullOrEmpty(personaje.info.prev))
                {
                    throw new Exception("No se puede volver ya que esta es la unica o primer pagina."); // No hay prev page.
                }

                Characters characters = new Characters();
                HttpResponseMessage response = await client.GetAsync(personaje.info.prev);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();

                    // Deserializo el JSON a un objeto de tipo Characters.
                    characters = JsonSerializer.Deserialize<Characters>(content);
                    return characters;
                }
                else
                {
                    throw new Exception("Error al obtener los datos. Código de estado: " + response.StatusCode);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}