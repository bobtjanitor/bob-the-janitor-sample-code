using Xamarin.Forms;

namespace SampleXamarinForms
{
    public class HomePage : TabbedPage
    {
       
        public HomePage()
        {
            Title = "Home Page";
            Children.Add(new NavigationPage(new HelloWorldPage()) { Title = "Hello World" });
            Children.Add(new NavigationPage(new HelloWordCodePage()) { Title = "Hello World from code" });
            Children.Add(new NavigationPage(new ClockPage()){Title = "Clock Page"});
            
        }
    }
}
