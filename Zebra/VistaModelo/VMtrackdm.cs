using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Zebra.VistaModelo
{
    public class VMtrackdm : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        #endregion

        #region CONSTRUCTOR
        public VMtrackdm(INavigation navigation)
        {
            Navigation = navigation;
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

        public async Task VolverTrack()
        {
            await Navigation.PopAsync();
        }

        public void ProcesoSimple()
        {

        }
        #endregion

        #region COMANDOS
        public ICommand VolverTrackCommand => new Command(async () => await VolverTrack());
        public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
        #endregion
    }
}