﻿using System.Collections.ObjectModel;
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
}

public class Item
{
    public string Text { get; set; }
    public string Value { get; set;}
}

public class Items : Collection<Item>
{}
