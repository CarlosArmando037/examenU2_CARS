using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using ExamenU2_CARS;

namespace ExamenU2_CARS.ViewModel
{
    internal class VMcalculadora : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        int _Duracion;
        int _Peso;
        
        //int _Respuesta;
        #endregion
        #region CONSTRUCTOR
        public VMcalculadora(INavigation navigation)
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
        public int Peso
        {
            get { return _Peso; }
            set { SetValue(ref _Peso, value); }
        }
        public int Respuesta
        {
            get { return _Peso; }
            set { SetValue(ref _Peso, value); }
        }
        public int Duracion
        {
            get { return _Duracion; }
            set { SetValue(ref _Duracion, value); }
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void Calcular()
        {
            //int repuesta=0;
            
            int respuesta = Peso * 10 * Duracion;

            if(respuesta < 250)
            {
                
                DisplayAlert("Alerta", "debe correr más tiempo y lograr superarse", "exit");
            }
            else if (respuesta > 250 && respuesta < 499)
            {
                DisplayAlert("Alerta", "vas por buen camino", "exit");

            }
            else
            {
                DisplayAlert("Alerta", "debe correr más tiempo y lograr superarse", "exit");
            }

        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncomand => new Command(async () => await ProcesoAsyncrono());
        public ICommand calcularcommand => new Command(Calcular);
        #endregion
    }
}
