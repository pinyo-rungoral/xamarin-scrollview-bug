using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App8
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        List<string> Items1 = new List<string>();
        List<string> Items2 = new List<string>();
        bool IsItem1 = true;

        public MainPage()
        {
            InitializeComponent();

            for (int i = 0; i < 4; i++)
            {
                Items1.Add(i.ToString());
            }

            for (int i = 0; i < 10; i++)
            {
                Items2.Add(i.ToString());
            }

           
        }

        private void OnDropdownSelected(object sender, ItemSelectedEventArgs e)
        {
         
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
       
        }
    }
}
