using Newtonsoft.Json;
using proiect_medii.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace proiect_medii.ViewModel
{
    public class AccuWeatherApi
    {
        public const string BaseApiUrl = "http://dataservice.accuweather.com/";
        public const string AutoCompleteEndpoint = "locations/v1/cities/autocomplete?apikey={0}&q={1}";
        public const string CurrentConditionsEndpoint = "currentconditions/v1/{0}?apikey={1}";
        public const string ApiKey = "kLr8y7gNi0dpvivyji72fPNJJnrkzrZF";

        public static async Task<List<City>> GetCities(string query)
        {
            List<City> cities = new List<City>();

            string url = BaseApiUrl + string.Format(AutoCompleteEndpoint, ApiKey, query);

            using (HttpClient client = new HttpClient())
            {
                try 
                {
                    var response = await client.GetAsync(url);
                    string json = await response.Content.ReadAsStringAsync();

                    cities = JsonConvert.DeserializeObject<List<City>>(json);
                }
                catch(Exception exception)
                {
                    Console.Write(exception.Message);
                }
                
            }
                return cities;
        }

        public static async Task<Weather> GetWeather(string cityKey)
        {
            Weather weather = new Weather();

            string url = BaseApiUrl + string.Format(CurrentConditionsEndpoint, cityKey, ApiKey);

            using (HttpClient client = new HttpClient())
            {
                try 
                {
                    var response = await client.GetAsync(url);
                    string json = await response.Content.ReadAsStringAsync();

                    weather = (JsonConvert.DeserializeObject<List<Weather>>(json)).FirstOrDefault();
                }
                catch(Exception exception)
                {
                    Console.Write(exception.Message);
                }
                
            }
            return weather;
        }
    }
}
