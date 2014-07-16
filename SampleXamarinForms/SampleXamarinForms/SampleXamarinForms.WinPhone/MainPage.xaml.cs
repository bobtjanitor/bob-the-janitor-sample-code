using Microsoft.Phone.Controls;
using Xamarin.Forms;


namespace SampleXamarinForms.WinPhone
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();

            Forms.Init();
            Content = SampleXamarinForms.App.GetMainPage().ConvertPageToUIElement(this);
        }
    }
}
