using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ToolsHome.Models;


namespace ToolsHome.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToDo : ContentPage
    {
        public ToDo()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            CargarItems();
        }

        private async void CargarItems()
        {
            var Tareas = await App.Context.GetItemsAsynx();
            cvTareas.ItemsSource = Tareas;
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CrearTareas());
        }
    }
}