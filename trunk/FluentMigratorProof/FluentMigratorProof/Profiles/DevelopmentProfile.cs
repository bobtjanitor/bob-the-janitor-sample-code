using FluentMigrator;

namespace FluentMigratorProof.Profiles
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
}