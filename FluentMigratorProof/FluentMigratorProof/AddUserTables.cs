using System;
using FluentMigrator;

namespace FluentMigratorProof
{
    [Migration(20110825124230)]
    public class AddCustomerTable : Migration
    {
        public override void Up()
        {
            Create.Table("Customers").WithColumn("Id").AsInt32().Identity().NotNullable()
                .WithColumn("Name").AsString().NotNullable()
                .WithColumn("Email").AsString();
        }

        public override void Down()
        {
            Delete.Table("Customers");
        }
    }

    [Migration(20110624232410)]
    public class AddUserTables : Migration
    {
        public override void Up()
        {
            Create.Table("Users")
                .WithColumn("Id").AsInt32().Identity().NotNullable()
                .WithColumn("Name").AsString().NotNullable()
                .WithColumn("Password").AsAnsiString().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("Users");
        }
    }
}
