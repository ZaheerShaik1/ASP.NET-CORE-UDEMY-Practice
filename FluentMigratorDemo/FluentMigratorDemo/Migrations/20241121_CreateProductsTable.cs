using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentMigratorDemo.Migrations
{
    [Migration(2024112106)]
    public class CreateProductsTable : Migration
    {
        public override void Up()
        {
            //Create.Table("Products")
            //    .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            //    .WithColumn("Name").AsString().NotNullable()
            //    .WithColumn("Price").AsDouble().NotNullable()
            //    .WithColumn("CreatedAt").AsDateTime().NotNullable();
            //Console.WriteLine("Table created");

            //Create.Table("Orders")
            //    .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            //    .WithColumn("Order_item").AsString().NotNullable()
            //    .WithColumn("ProductsId").AsInt32().NotNullable();

            //Create.ForeignKey("ForeignKey")
            //    .FromTable("Orders").ForeignColumn("ProductsId")
            //    .ToTable("Products").PrimaryColumn("Id");

            //Insert.IntoTable("Products")
            //    .Row(new { Name = "Burger", Price = 98.89, CreatedAt = new DateTime(2024, 11, 21) });
            //Insert.IntoTable("Orders")
            //    .Row(new { Order_item = "Pizza", ProductsId = 1 });

            //Insert.IntoTable("Orders")
            //    .Row(new { Order_item = "Chicken",ProductsId=10});
            //Update.Table("Products")
            //    .Set(new { Name = "Biriyani", price = 120.40, CreatedAt = new DateTime(2024, 11, 20) })
            //    .Where(new { Id=2});
            //Delete.Table("Orders");

            Delete.FromTable("Orders")
                .Row(new {Order_item="Chicken"});
        

            Console.WriteLine("Inserting entries");

        }
        public override void Down()
        {
            //Delete.ForeignKey("ForeignKey").OnTable("Orders");

            //Delete.Table("Orders");
            //Delete.Table("Products");

            Console.WriteLine("hw");
        }
    }
}
