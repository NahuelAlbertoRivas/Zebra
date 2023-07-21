using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Zebra.Vistas;

namespace Zebra.VistaModelo
{
    public class VMmainPage:BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        #endregion

        #region CONSTRUCTOR
        public VMmainPage(INavigation navigation)
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

        public async Task NavCom()
        {
            await Navigation.PushAsync(new Comunidad());
        }
        
        public async Task NavProd()
        {
            await Navigation.PushAsync(new Productos());
        }

        public async Task NavTim()
        {
            await Navigation.PushAsync(new Timer());
        }

        public async Task NavTrack()
        {
            await Navigation.PushAsync(new TrackdeMacros());
        }

        public void ProcesoSimple()
        {

        }
        #endregion

        #region COMANDOS
        public ICommand ProcesoAsyncCommand => new Command(async () => await ProcesoAsincrono());
        public ICommand NavAComCommand => new Command(async () => await NavCom());
        public ICommand NavAProdCommand => new Command(async () => await NavProd());
        public ICommand NavATimCommand => new Command(async () => await NavTim());
        public ICommand NavATrackCommand => new Command(async () => await NavTrack());
        public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
        #endregion
    }
}
