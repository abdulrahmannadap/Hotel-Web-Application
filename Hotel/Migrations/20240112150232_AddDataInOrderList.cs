using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Migrations
{
    public partial class AddDataInOrderList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [orderListsTable] VALUES ('Masala dosa')");
            migrationBuilder.Sql("INSERT INTO [orderListsTable] VALUES ('Chole bhature')");
            migrationBuilder.Sql("INSERT INTO [orderListsTable] VALUES ('Aloo gobi')");
            migrationBuilder.Sql("INSERT INTO [orderListsTable] VALUES ('Vada')");
            migrationBuilder.Sql("INSERT INTO [orderListsTable] VALUES ('Tandoori chicken')");
            migrationBuilder.Sql("INSERT INTO [orderListsTable] VALUES ('Samosa')");
            migrationBuilder.Sql("INSERT INTO [orderListsTable] VALUES ('Rogan josh')");
            migrationBuilder.Sql("INSERT INTO [orderListsTable] VALUES ('Palak paneer')");
            migrationBuilder.Sql("INSERT INTO [orderListsTable] VALUES ('Biryani')");
            migrationBuilder.Sql("INSERT INTO [orderListsTable] VALUES ('Butter chicken')");
            migrationBuilder.Sql("INSERT INTO [orderListsTable] VALUES ('Dal')");
            migrationBuilder.Sql("INSERT INTO [orderListsTable] VALUES ('Dosa')");
            migrationBuilder.Sql("INSERT INTO [orderListsTable] VALUES ('Idli')");
            migrationBuilder.Sql("INSERT INTO [orderListsTable] VALUES ('Naan')");
            migrationBuilder.Sql("INSERT INTO [orderListsTable] VALUES ('Chaat')");
            migrationBuilder.Sql("INSERT INTO [orderListsTable] VALUES ('Tea')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
               name: "customersTable");

            migrationBuilder.DropTable(
                name: "orderListsTable");
        }
    }
}
