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
    public partial class Timer : ContentPage
    {
        VMtimer vm;
        public Timer()
        {
            InitializeComponent();
            vm = new VMtimer(Navigation);
            BindingContext = vm;
        }
    }
}