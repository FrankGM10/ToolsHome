using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToolsHome.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class mts2 : ContentPage
    {
        public mts2()
        {
            InitializeComponent();
        }
        public  void Button_Clicked(object sender, EventArgs e)
        {
            var alto = Convert.ToDouble(txtAlto.Text);
            var ancho = Convert.ToDouble(txtAncho.Text);

            var calcular = alto * ancho;
            lblRespuesta.Text = calcular.ToString();
        }
    }
  
}