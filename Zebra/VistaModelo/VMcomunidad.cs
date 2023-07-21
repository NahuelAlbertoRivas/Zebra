using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Zebra.VistaModelo
{
    public class VMcomunidad : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        #endregion

        #region CONSTRUCTOR
        public VMcomunidad(INavigation navigation)
        {
            Navigation = navigation;
            ValidarConexionInternet();
        }
        #endregion

        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion

        #region PROCESOS
        public async Task ProcesoAsincrono()
        {

        }

        public async Task VolverCom()
        {
            await Navigation.PopAsync();
        }


        public void ProcesoSimple()
        {

        }
        #endregion

        #region COMANDOS
        public ICommand ProcesoAsyncCommand => new Command(async () => await ProcesoAsincrono());
        public ICommand VolverComCommand => new Command(async () => await VolverCom());
        public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
        #endregion
    }
}