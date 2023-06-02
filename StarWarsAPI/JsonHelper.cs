using System;
using Newtonsoft.Json;
using StarWarsAPI.Objects;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsAPI
{
    //Public class
    public class JsonHelper
    {
        //Reads the Star Wars API url
        static readonly HttpClient client = new HttpClient();

        //Input an id for planet and will display information about that planet's id if there is no error 
        //otherwise an error message will print
        //gets information from Star Wars API url.
        public static async Task<Planet> GetPlanet(string PlanetId)
        {
            Planet myDeserializedClass = new Planet();
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://swapi.dev/api/planets/" + PlanetId + " / ");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                myDeserializedClass = JsonConvert.DeserializeObject<Planet>(responseBody);
            }
            catch (HttpRequestException ex) 
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", ex.Message);
            }
            return myDeserializedClass; 
        }

        //Input an id for people and will display information about that person's id if there is no error 
        //otherwise an error message will print and 
        //gets information from Star Wars API url.
        public static async Task<People> GetPeople(string PersonId)
        {
            People myDeserializedClass = new People();
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://swapi.dev/api/people/" + PersonId + "/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                myDeserializedClass = JsonConvert.DeserializeObject<People>(responseBody);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", ex.Message);
            }
            return myDeserializedClass;
        }

        //Displays all information about species if there is no error 
        //otherwise an error message will print
        //gets information from Star Wars API url.
        public static async Task<AllSpecies> GetAllSpecies()
        {
            AllSpecies myDeserializedClass = new AllSpecies();
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://swapi.dev/api/species/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                myDeserializedClass = JsonConvert.DeserializeObject<AllSpecies>(responseBody); 
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", ex.Message);
            }
            return myDeserializedClass; 
        }

    }
}
