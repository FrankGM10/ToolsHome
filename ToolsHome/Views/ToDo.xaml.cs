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

        private async void DeleteButton_Clicked(object sender, EventArgs e)
        {
            var tarea = (Tarea)((Button)sender).CommandParameter;

            if (await DisplayAlert("Confirmación", "¿Seguro que quiere Eliminar?", "Sí", "No"))
            {
                int rowsAffected = await App.Context.DeleteItemAsync(tarea);
                if (rowsAffected > 0)
                {
                    var tarea1 = (List<Tarea>)cvTareas.ItemsSource;
                    tarea1.Remove(tarea);

                    cvTareas.ItemsSource = null;
                    cvTareas.ItemsSource = tarea1;

                }
                else
                {
                    await DisplayAlert("Error", "No se pudo eliminar", "Aceptar");
                }
            }
        }
    }
}