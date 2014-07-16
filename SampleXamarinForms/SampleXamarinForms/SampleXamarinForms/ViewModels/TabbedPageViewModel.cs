using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SampleXamarinForms.ViewModels
{
    public class TabbedPageViewModel   
    {
        public TabbedPageViewModel()
        {
            TabData = new ObservableCollection<PageDataItem> 
            {
                new PageDataItem
                {
                    PageName = "Page 1",
                    PageDescription = "On Page One we talk about HelloWorld"
                },
                new PageDataItem
                {
                    PageName = "Page 2",
                    PageDescription = "On Page two we talk about things happening"
                },
                new PageDataItem
                {
                    PageName = "Page 3",
                    PageDescription = "On Page 3 we talk about things that happened"
                },
            }; 
        }

        public IList<PageDataItem> TabData { get; set; }  
    }

    public class PageDataItem
    {
        public string PageName { get; set; }
        public string PageDescription { get; set; }
    }
}