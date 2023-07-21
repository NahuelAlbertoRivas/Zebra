using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Zebra.VistaModelo;

namespace Zebra.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Comunidad : ContentPage
    {
        VMcomunidad vm;
        public Comunidad()
        {
            InitializeComponent();
            vm = new VMcomunidad(Navigation);
            BindingContext = vm;

        }
    }
}