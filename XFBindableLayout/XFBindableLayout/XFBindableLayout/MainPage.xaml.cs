using System.ComponentModel;
using Xamarin.Forms;
using XFBindableLayout.ViewModels;

namespace XFBindableLayout
{
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ((MainPageViewModel)BindingContext).LoadPersonsCommand.Execute(null);
        }
    }
}
