using System;
using Xamarin.Forms;

namespace Binomial
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        private async void getTime(object sender, EventArgs e)
        {

            await DisplayAlert("Horario Atual:", getTimes(), "Cancelar");
        }

        public static string getTimes()
        {
            try
            {

                var tempo = DateTime.Now;
                var hora = tempo.Hour.ToString();
                var min = tempo.Minute.ToString();
                var mil = tempo.Second.ToString();
                var dia = tempo.Day.ToString();
                var mes = tempo.Second.ToString();
                var horario = dia + "/" + mes + " - " + hora + ":" + min + ":" + mil;
                
                return horario;
            }
            catch (Exception)
            {
                return "Erro";
            }
        }

        private void tela2(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Screen2());
        }
        private void getHistory(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Historico());
        }
    }
}
