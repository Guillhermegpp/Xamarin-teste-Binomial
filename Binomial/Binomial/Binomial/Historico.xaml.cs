using SQLite.Net.Attributes;
using SQLite.Net.Interop;
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
    public partial class Historico : ContentPage
    {
        string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "temp.txt");
        public Historico()
        {
            InitializeComponent();
           
            output.Text = File.ReadAllText(fileName);
        }


        private void voltar(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
        private void limpar(object sender, EventArgs e)
        {
            File.WriteAllText(fileName,"");

            output.Text = File.ReadAllText(fileName);
        }
    }
    

}