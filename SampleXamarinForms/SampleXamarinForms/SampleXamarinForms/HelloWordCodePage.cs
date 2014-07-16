using Xamarin.Forms;

namespace SampleXamarinForms
{
    public class HelloWordCodePage : ContentPage
    {
        public Label HelloWorldLabel;

        public HelloWordCodePage()
        {
            HelloWorldLabel = new Label{Text = "Hello World", };
            ConstructView();
        }

        public void ConstructView()
        {
            Content = new StackLayout
            {
                Children =
                {
                    HelloWorldLabel
                }
            };
        }
    }
}