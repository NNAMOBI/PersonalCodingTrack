using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clubs_User_UserId",
                table: "Clubs");

            migrationBuilder.DropForeignKey(
                name: "FK_Races_User_UserId",
                table: "Races");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropColumn(
                name: "Desription",
                table: "Clubs");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Clubs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "PostalCode", "State", "Street" },
                values: new object[,]
                {
                    { 1, "New York", "10001", "NY", "123 Main St" },
                    { 2, "Los Angeles", "90001", "CA", "456 Elm St" },
                    { 3, "Chicago", "60601", "IL", "789 Oak St" },
                    { 4, "Houston", "77001", "TX", "321 Pine St" },
                    { 5, "Miami", "33101", "FL", "567 Maple St" },
                    { 6, "Seattle", "98101", "WA", "890 Cedar St" },
                    { 7, "Boston", "02101", "MA", "234 Birch St" },
                    { 8, "San Francisco", "94101", "CA", "876 Walnut St" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AddressId", "Email", "Name", "Password" },
                values: new object[,]
                {
                    { 1, 3, "Reb@gmail.com", "Rebecca Osuagwu", "jdahfaodao" },
                    { 2, 4, "OwenHargereaves@gmail.com", "Owen Hagreaves", "owndealtio" },
                    { 3, 5, "jane@example.com", "Matthew Oakson", "examplepassword2" },
                    { 4, 3, "jane@example.com", "Matthew Oakson", "examplepassword2" }
                });

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AddressId", "ClubCategory", "Description", "Image", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, 2, 4, "For those who seek endurance challenges", "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360", "Endurance Club", 2 },
                    { 2, 5, 0, "For those who love speed and adrenaline", "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360", "Speed Racing Club", 3 },
                    { 3, 7, 2, "Exploring the great outdoors and challenging terrains", "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360", "Adventure Club", 2 },
                    { 4, 8, 3, "Promoting health and fitness through various activities", "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360", "Fitness Club", 3 }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "AddressId", "Contact", "Description", "EntryFee", "Facebook", "Image", "RaceCategory", "StartTime", "Title", "Twitter", "UserId", "Website" },
                values: new object[,]
                {
                    { 1, 1, "not yet", "Cross country race", 500, "race face", "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360", 2, new DateTime(2024, 4, 4, 18, 23, 4, 469, DateTimeKind.Local).AddTicks(9300), "formula 1", "@twiRace", 1, "WWW.getRaceCourse" },
                    { 2, 2, "not yet", "country race", 2000, "race face2", "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360", 0, new DateTime(2024, 4, 4, 18, 23, 4, 469, DateTimeKind.Local).AddTicks(9355), "formula 1 pro", "@twiRace2", 2, "WWW.getRaceCoursenew" },
                    { 3, 3, "Jane Doe", "Short-distance running race", 1000, "SprintChallenge", "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360", 4, new DateTime(2024, 4, 4, 19, 23, 4, 469, DateTimeKind.Local).AddTicks(9359), "Sprint Challenge", "@SprintChallenge", 3, "www.sprintchallenge.com" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Clubs_Users_UserId",
                table: "Clubs",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Races_Users_UserId",
                table: "Races",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clubs_Users_UserId",
                table: "Clubs");

            migrationBuilder.DropForeignKey(
                name: "FK_Races_Users_UserId",
                table: "Races");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Clubs");

            migrationBuilder.AddColumn<int>(
                name: "Desription",
                table: "Clubs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressId = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_AddressId",
                table: "User",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clubs_User_UserId",
                table: "Clubs",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Races_User_UserId",
                table: "Races",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
