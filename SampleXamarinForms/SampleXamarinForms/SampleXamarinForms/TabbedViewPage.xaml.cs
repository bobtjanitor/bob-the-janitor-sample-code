using SampleXamarinForms.ViewModels;

namespace SampleXamarinForms
{
    public partial class TabbedViewPage
    {
        public TabbedViewPage()
        {
            InitializeComponent();
            this.ItemsSource = new TabbedPageViewModel().TabData;
        }
    }
}
