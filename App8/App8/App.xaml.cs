using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App8
{
    public partial class App : Application
    {
        public App()    
        {
            Plugin.Iconize.Iconize
                         .With(new Plugin.Iconize.Fonts.FontAwesomeRegularModule())
                         .With(new Plugin.Iconize.Fonts.FontAwesomeBrandsModule())
                         .With(new Plugin.Iconize.Fonts.FontAwesomeSolidModule());
                       

            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
