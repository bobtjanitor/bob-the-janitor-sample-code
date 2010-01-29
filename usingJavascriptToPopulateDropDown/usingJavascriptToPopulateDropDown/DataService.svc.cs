using System.Collections.ObjectModel;
using System.ServiceModel;
using System.ServiceModel.Activation;


[ServiceContract(Namespace = "")]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class DataService
{
    [OperationContract]
    public Items GetData()
    {
        Items myItems = new Items();
        for (int i = 0; i < 5; i++)
        {
            Item newItem = new Item()
               {
                   Text = string.Format("value {0}", i), 
                   Value = i.ToString()
               };
            myItems.Add(newItem);
        }
        return myItems;
    }

    [OperationContract]
    public Items GetCountryData()
    {
        Items myItems = new Items()
                            {
                                new Item(){Text = "US",Value = "USA"},
                                new Item(){Text = "Canada",Value = "CAN"},
                                new Item(){Text = "Mexico",Value = "MEX"}
                            };        
        return myItems;
    }

    [OperationContract]
    public Items GetStateData(string country)
    {
        Items myItems = new Items();

        switch (country)
        {
            case "USA":
                myItems.Add(new Item(){Text = "ID",Value = "ID"});
                break;
            case "CAN":
                myItems.Add(new Item() { Text = "AB", Value = "AB" });
                break;
            case "MEX":
                myItems.Add(new Item() { Text = "QB", Value = "QB" });
                break;
        }
        return myItems;
    }


}

public class Item
{
    public string Text { get; set; }
    public string Value { get; set;}
}

public class Items : Collection<Item>
{}
