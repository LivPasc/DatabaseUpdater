using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseUpdater.Migrations
{
    public partial class ValuesModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ValuesModels",
                columns: table => new
                {
                    MicrocontrollerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Temperature = table.Column<float>(type: "real", nullable: false),
                    Humidity = table.Column<float>(type: "real", nullable: false),
                    Dust = table.Column<float>(type: "real", nullable: false),
                    DoorOpen = table.Column<bool>(type: "bit", nullable: false),
                    Power = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValuesModels", x => x.MicrocontrollerID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ValuesModels");
        }
    }
}
