﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServices.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebServices.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BeerPage : ContentPage
    {
        public BeerPage()
        {
            InitializeComponent();
            BindingContext = new BeerPageViewModel();
        }
    }
}