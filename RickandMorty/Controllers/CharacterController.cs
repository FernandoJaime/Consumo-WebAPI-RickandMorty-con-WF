using RickandMorty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

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

        // Metodo que regresa todos los characters que tengan esa letra o letras en el nombre.
        public async Task<Characters> GetForName(string name)
        {
            try
            {
                Characters characters = new Characters();
                HttpResponseMessage response = await client.GetAsync("https://rickandmortyapi.com/api/character?name=" + name);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    characters = JsonSerializer.Deserialize<Characters>(content); // Deserializo.
                    return characters;
                }
                else if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    // El nombre solicitado no existe, devolver un mensaje.
                    throw new Exception("No existe personaje con ese nombre o letra en su nombre.");
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

        // Metodo que regresa todos los characters que tengan esa letra o letras en el nombre con ese status especifico.
        public async Task<Characters> GetForNameAndStatus(string name, string status)
        {
            try
            {
                Characters characters = new Characters();
                HttpResponseMessage response = await client.GetAsync($"https://rickandmortyapi.com/api/character?name={name}&status={status}");
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    characters = JsonSerializer.Deserialize<Characters>(content); // Deserializo.
                    return characters;
                }
                else if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    throw new Exception($"No existe personaje que se encuentre {status} con ese nombre o letra en su nombre.");
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