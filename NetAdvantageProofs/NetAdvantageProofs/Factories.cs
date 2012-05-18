using NetAdvantageProofs.Data;

namespace NetAdvantageProofs
{
    public static class Factories
    {
        public static AdventureWorks GetAdventureWorks()
        {
            return new AdventureWorks();
        }
    }
}