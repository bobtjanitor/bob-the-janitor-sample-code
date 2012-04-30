using System.ComponentModel;

namespace SampleApplication.Objects.Enums
{
    public enum BuildingTypes
    {
        [Description("Retail Space")]
        RetailSpace=1,
        [Description("Office Space")]
        OfficeSpace=2,
        [Description("Single Family Residence")]
        SingleFamilyResidence=3,
        [Description("Multi Family Residence")]
        MultiFamilyResidence=4,
        [Description("Warehouse")]
        Warehouse =5,
        [Description("Manufacturing")]
        Manufacturing =6
    }
}