using Bitventure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Bitventure
{
    class Api_Helper
    {
        public void readurl(string URL)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(URL);
             
                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync(URL).Result;
                if (response.IsSuccessStatusCode)
                {

                    var ListItems = response.Content.ReadAsAsync<ApiEndpoints>().Result;
                  
                    Console.WriteLine(ListItems.films);
                    Console.WriteLine(ListItems.people);
                    Console.WriteLine(ListItems.planets);
                    Console.WriteLine(ListItems.species);
                    Console.WriteLine(ListItems.starships);
                    Console.WriteLine(ListItems.vehicles);
                    
                    readPeople(ListItems.people);
                    readPlanet(ListItems.people);
                    readSpecies(ListItems.species);
                    readStarships(ListItems.starships);
                    readVehicles(ListItems.vehicles);
                    readFilms(ListItems.films);
                }
                else
                {
                    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                }
                client.Dispose();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void readPlanet(string URL)
        {
            URL = URL + "1";
            HttpClient client1 = new HttpClient();
            client1.BaseAddress = new Uri(URL);
            client1.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response1 = client1.GetAsync(URL).Result;
            if (response1.IsSuccessStatusCode)
            {
                Console.WriteLine("");
                Console.WriteLine("PLANETS");
    
                var ListItems = response1.Content.ReadAsAsync<Planets>().Result;
                Console.WriteLine(ListItems.Name);
                Console.WriteLine(ListItems.Rotation_period);
                Console.WriteLine(ListItems.Orbital_period);
                Console.WriteLine(ListItems.Diameter);
                Console.WriteLine(ListItems.Climate);
                Console.WriteLine(ListItems.Gravity);
                Console.WriteLine(ListItems.Terrain);
                Console.WriteLine(ListItems.Surface_water);
                Console.WriteLine(ListItems.Population);
                if(ListItems.Residents != null)
                {
                    foreach (var item in ListItems.Residents)
                    {
                        Console.WriteLine("Ressidents : {0}", item.ToString());
                    }
                }
                if (ListItems.Films != null)
                {
                    foreach (var item in ListItems.Films)
                    {
                        Console.WriteLine("Films : {0}", item.ToString());
                    }
                }
               
                

                Console.WriteLine(ListItems.Created);
                Console.WriteLine(ListItems.Edited);
                Console.WriteLine(ListItems.Url);
            }
        }
        public void readSpecies(string URL)
        {
            URL = URL + "1";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync(URL).Result;
            if (response.IsSuccessStatusCode)
            {
                var ListItems = response.Content.ReadAsAsync<Species>().Result;
                Console.WriteLine("");
                Console.WriteLine("SPECIES");
                Console.WriteLine(ListItems.Name);
                Console.WriteLine(ListItems.Classification);
                Console.WriteLine(ListItems.Designation);
                Console.WriteLine(ListItems.Average_height);
                Console.WriteLine(ListItems.Skin_colors);
                Console.WriteLine(ListItems.Hair_colors);
                Console.WriteLine(ListItems.Eye_colors);
                Console.WriteLine(ListItems.Average_lifespan);
                Console.WriteLine(ListItems.Homeworld);
                Console.WriteLine(ListItems.Language);
                Console.WriteLine(ListItems.Homeworld);
                if (ListItems.People != null)
                {
                    foreach (var item in ListItems.People)
                    {
                        Console.WriteLine("People : {0}", item.ToString());
                    }
                }
                if (ListItems.Films != null)
                {
                    foreach (var item in ListItems.Films)
                    {
                        Console.WriteLine("Films : {0}", item.ToString());
                    }
                }
                Console.WriteLine(ListItems.Created);
                Console.WriteLine(ListItems.Edited);
                Console.WriteLine(ListItems.Url);
            }
        }
        public void readVehicles(string URL)
        {
            URL = URL + "1";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync(URL).Result;
            if (response.IsSuccessStatusCode)
            {
                var ListItems = response.Content.ReadAsAsync<Vehicles>().Result;
                Console.WriteLine("");
                Console.WriteLine("VEHICLES");
                Console.WriteLine(ListItems.Name);
                Console.WriteLine(ListItems.Model);
                Console.WriteLine(ListItems.Manufacturer);
                Console.WriteLine(ListItems.Cost_in_credits);
                Console.WriteLine(ListItems.Length);
                Console.WriteLine(ListItems.Crew);
                Console.WriteLine(ListItems.Passengers);
                Console.WriteLine(ListItems.Cargo_capacity);
                Console.WriteLine(ListItems.Consumables);
                Console.WriteLine(ListItems.Vehicle_class);
                if (ListItems.Pilots != null)
                {
                    foreach (var item in ListItems.Pilots)
                    {
                        Console.WriteLine("Pilots : {0}", item.ToString());
                    }
                }
                if (ListItems.Films != null)
                {
                    foreach (var item in ListItems.Films)
                    {
                        Console.WriteLine("Films : {0}", item.ToString());
                    }
                }
                Console.WriteLine(ListItems.Created);
                Console.WriteLine(ListItems.Edited);
                Console.WriteLine(ListItems.Url);
            }
        }
        public void readStarships(string URL)
        {
            URL = URL + "1";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync(URL).Result;
            if (response.IsSuccessStatusCode)
            {
                var ListItems = response.Content.ReadAsAsync<Starships>().Result;
                Console.WriteLine("");
                Console.WriteLine("STARSHIPS");
                Console.WriteLine(ListItems.Name);
                Console.WriteLine(ListItems.Model);
                Console.WriteLine(ListItems.Manufacturer);
                Console.WriteLine(ListItems.Cost_in_credits);
                Console.WriteLine(ListItems.Length);
                Console.WriteLine(ListItems.Max_atmosphering_speed);
                Console.WriteLine(ListItems.Crew);
                Console.WriteLine(ListItems.Passengers);
                Console.WriteLine(ListItems.Cargo_capacity);
                Console.WriteLine(ListItems.Consumables);
                Console.WriteLine(ListItems.Hyperdrive_rating);
                Console.WriteLine(ListItems.MGLT);
                Console.WriteLine(ListItems.Starship_class);
                if (ListItems.Pilots != null)
                {
                    foreach (var item in ListItems.Pilots)
                    {
                        Console.WriteLine("Pilots : {0}", item.ToString());
                    }
                }
                if (ListItems.Films != null)
                {
                    foreach (var item in ListItems.Films)
                    {
                        Console.WriteLine("Films : {0}", item.ToString());
                    }
                }
                
                

                Console.WriteLine(ListItems.Created);
                Console.WriteLine(ListItems.Edited);
                Console.WriteLine(ListItems.Url);
            }
        }
        public void readPeople(string URL)
        {
            URL = URL + "1";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync(URL).Result;
            if (response.IsSuccessStatusCode)
            {
                var ListItems = response.Content.ReadAsAsync<People>().Result;
                Console.WriteLine("");
                Console.WriteLine("PEOPLE");
                Console.WriteLine(ListItems.Name);
                Console.WriteLine(ListItems.Height);
                Console.WriteLine(ListItems.Mass);
                Console.WriteLine(ListItems.Hair_color);
                Console.WriteLine(ListItems.Skin_color);
                Console.WriteLine(ListItems.Eye_color);
                Console.WriteLine(ListItems.Birth_year);
                Console.WriteLine(ListItems.Gender);
                Console.WriteLine(ListItems.Homeworld);
                if (ListItems.Starships != null)
                {
                    foreach (var item in ListItems.Starships)
                    {
                        Console.WriteLine("Starships : {0}", item.ToString());
                    }
                }
                if (ListItems.Vehicles != null)
                {
                    foreach (var item in ListItems.Vehicles)
                    {
                        Console.WriteLine("Vehicles : {0}", item.ToString());
                    }
                }
                if (ListItems.Species != null)
                {
                    foreach (var item in ListItems.Species)
                    {
                        Console.WriteLine("Species : {0}", item.ToString());
                    }
                }
               
                
                
                Console.WriteLine(ListItems.Created);
                Console.WriteLine(ListItems.Edited);
                Console.WriteLine(ListItems.Url);
            }
        }
        public void readFilms(string URL)
        {
            try
            {
                URL = URL + "1";
                HttpClient client2 = new HttpClient();
                client2.BaseAddress = new Uri(URL);
                client2.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response2 = client2.GetAsync(URL).Result;
                if (response2.IsSuccessStatusCode)
                {
                    Console.WriteLine("");
                    Console.WriteLine("FILMS");           
                    var ListItems = response2.Content.ReadAsAsync<Films>().Result;
                    Console.WriteLine(ListItems.Title);
                    Console.WriteLine(ListItems.Episode_id);
                    Console.WriteLine(ListItems.opening_crawl);
                    Console.WriteLine(ListItems.Director);
                    Console.WriteLine(ListItems.Producer);
                    Console.WriteLine(ListItems.Release_date);
                    
                    
                   
                    
                    if (ListItems.Planets != null)
                    {
                        foreach (var item in ListItems.Planets)
                        {
                            Console.WriteLine("Plantes : ", item.ToString());
                        }
                    }
                    if (ListItems.Characters != null)
                    {
                        foreach (var item in ListItems.Characters)
                        {
                            Console.WriteLine("Chracters : {0}", item.ToString());
                        }

                    }
                    if (ListItems.Starships != null)
                    {
                        foreach (var item in ListItems.Starships)
                        {
                            Console.WriteLine("Starships : {0}", item.ToString());
                        }
                    }
                    if (ListItems.Vehicles != null)
                    {
                        foreach (var item in ListItems.Vehicles)
                        {
                            Console.WriteLine("Vehicles : {0}", item.ToString());
                        }
                    }
                    if (ListItems.Starships != null)
                    {
                        foreach (var item in ListItems.Species)
                        {
                            Console.WriteLine("Species : {0}", item.ToString());
                        }
                    }
                    Console.WriteLine(ListItems.Created);
                    Console.WriteLine(ListItems.Edited);
                    Console.WriteLine(ListItems.Url);
                }
                else
                {
                    Console.WriteLine("{0} ({1})", (int)response2.StatusCode, response2.ReasonPhrase);
                }
                client2.Dispose();
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
