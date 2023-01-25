using System;
using proiect_medii.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace proiect_medii.ViewModel
{
    public class WeatherViewModel : INotifyPropertyChanged
    {
        private string query;
        public string Query
        {
            get { return query; }
            set
            {
                query = value;
                OnPropertyChanged("Query");
            }
        }

        public ObservableCollection<City> Cities { get; set; }

        private Weather weather;
        public Weather Weather
        {
            get { return weather; }
            set
            {
                weather = value;
                OnPropertyChanged("Weather");
            }
        }

        private City selectedCity;
        public City SelectedCity
        {
            get { return selectedCity; }
            set 
            { 
                selectedCity = value;
                if (selectedCity != null)
                {
                    OnPropertyChanged("SelectedCity");
                    GetWeather();
                }
            }
        }

        public SearchCommand SearchCommand { get; set; }

        public WeatherViewModel()
        {
            SearchCommand = new SearchCommand(this);
            Cities = new ObservableCollection<City>();
        }

        private async void GetWeather()
        {
            Query = string.Empty;
            Weather = await AccuWeatherApi.GetWeather(SelectedCity.Key);
            SaveWeatherAsJson(Weather);
            Cities.Clear();
        }

        public async void MakeQuery()
        {
            var cities = await AccuWeatherApi.GetCities(Query);

            Cities.Clear();
            foreach(var city in cities)
            {
                Cities.Add(city);
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void SaveWeatherAsJson(Weather weather)
        {
            string json = JsonConvert.SerializeObject(weather, Formatting.Indented);
            System.IO.File.WriteAllText(@"D:\proiect.txt", json);
        }
    }
}
