using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WebServices.Models;
using WebServices.Services;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace WebServices.ViewModels
{
    public class BeerPageViewModel : INotifyPropertyChanged
    {
        IApiBeers _apibeer = new ApiBeers();

        public event PropertyChangedEventHandler PropertyChanged;

        public string BeerId { get; set; }
        public List<Beer> BeerIngedientInfo { get; set; }
        public DataBeer Data { get; set; } = new DataBeer();
        public ICommand Search { get; set; }
        public BeerPageViewModel()
        {
            Search = new Command(async() =>
            {
                await GetBeerIngredientData();
            });
 
        }
        async Task GetBeerIngredientData()
        {
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                try
                {
                    var GetData = await _apibeer.GetBeerInfo(BeerId);
                    BeerIngedientInfo = new List<Beer>(GetData.Data);


                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"API EXCEPTION {ex}");
                    await App.Current.MainPage.DisplayAlert("error", $"{ex}", "ok");
                }

            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Alet", "No tienes Conexion a internet", "Ok");
            }
        }
    }
}
