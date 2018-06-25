
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Binomial
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Screen2 : ContentPage
	{
        string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "temp.txt");
        public Screen2 ()
		{
			InitializeComponent ();
            
		}
        private void voltar(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
        private void Calcular_Clicked(object sender, EventArgs e)
        {
            Model m = new Model();
            int nn = int.Parse(n.Text);
            int kk = int.Parse(k.Text);
            double pp = m.transforma(p.Text);
            double qq = m.transforma(q.Text);
            var P = (m.fat(nn) / (m.fat(kk) * m.fat(nn - kk))) * Math.Pow(pp, kk) * Math.Pow(qq, (nn - kk));
            string result = "\n\tP(X="+kk+"): " + P + " ou " + (P * 100) + "% ";
            calulo.Text = result;
            var horario = MainPage.getTimes();
            //DisplayAlert("", horario + "\n" + result, "cancel");
            History his = new History();
            his.hora = horario;
            his.resul = result;
            var novo = "";
            
            if (File.Exists(fileName))
                novo = File.ReadAllText(fileName);
            novo += his;
            File.WriteAllText(fileName, novo);
        }

       
        



    }


}