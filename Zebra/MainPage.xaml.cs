using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Zebra.VistaModelo;

namespace Zebra
{
    public partial class MainPage : ContentPage
    {
        VMmainPage vm;
        public MainPage()
        {
            InitializeComponent();
            vm = new VMmainPage(Navigation);
            BindingContext = vm;
        }
    }
}
