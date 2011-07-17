using FluentMigrator;

namespace FluentMigratorProof
{
    [Profile("Development")]
    public class DevelopmentProfile : Migration
    {
        public override void Up()
        {

            Insert.IntoTable("Users").Row(new { Name = "TestUser", Password = "12345" });
        }

        public override void Down()
        {
            Execute.Sql("DELETE FROM `Users` WHERE Name = 'TestUser'");
        }
    }

    [Profile("Production")]
    public class ProductionProfile : Migration
    {
        public override void Up()
        {

            
        }

        public override void Down()
        {
            
        }
    }
}