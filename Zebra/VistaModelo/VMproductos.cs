using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Zebra.Datos;
using Zebra.Modelo;

namespace Zebra.VistaModelo
{
    public class VMproductos:BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        List<Mproductos> _listaproductos;
        #endregion

        #region CONSTRUCTOR
        public VMproductos(INavigation navigation, StackLayout Mancuernas, StackLayout Pesas, StackLayout Barras, StackLayout Maquinas, StackLayout Otros)
        {
            Navigation = navigation;
            ValidarConexionInternet();
            Mostrarproductos(Mancuernas, Pesas, Barras, Maquinas, Otros);
        }
        #endregion

        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }

        public List<Mproductos> Listaproductos
        {
            get { return _listaproductos; }
            set { SetValue(ref _listaproductos, value); }
        }
        #endregion

        #region PROCESOS

        public async Task Mostrarproductos(StackLayout Mancuernas, StackLayout Pesas, StackLayout Barras, StackLayout Maquinas, StackLayout Otros)
        {
            var funcion = new Dproductos();
            Listaproductos = await funcion.Mostrarproductos();
            foreach(var item in Listaproductos)
            {
                Crearpanelproductos(item, Mancuernas, Pesas, Barras, Maquinas, Otros);
            }
        }

        public void Crearpanelproductos (Mproductos item, StackLayout Mancuernas, StackLayout Pesas, StackLayout Barras, StackLayout Maquinas, StackLayout Otros)
        {
            var _ubicacion = item.Tipo;
            var carril = Otros;
            switch(_ubicacion)
            {
                case "0": carril = Mancuernas;
                    break;
                case "1": carril = Pesas;
                    break;
                case "2": carril = Barras;
                    break;
                case "3": carril = Maquinas;
                    break;
                case "4": carril = Otros;
                    break;
            }
            var image = new Image
            {
                HeightRequest = 90,
                WidthRequest = 90,
                VerticalOptions = LayoutOptions.Start,
                Margin = 15,
                Source = item.Icono
            };
            carril.Children.Add(image);
        }

        public async Task VolverProd()
        {
            await Navigation.PopAsync();
        }

        public void ProcesoSimple()
        {

        }
        #endregion

        #region COMANDOS
        public ICommand VolverProdCommand => new Command(async () => await VolverProd());
        public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
        #endregion
    }
}
