using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Job_serach.Migrations
{
    public partial class Evsmigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_user_type_UserTypeID1",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_users_UserTypeID1",
                table: "users");

            migrationBuilder.DropColumn(
                name: "UserTypeID1",
                table: "users");

            migrationBuilder.CreateIndex(
                name: "IX_users_UserTypeID",
                table: "users",
                column: "UserTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_users_user_type_UserTypeID",
                table: "users",
                column: "UserTypeID",
                principalTable: "user_type",
                principalColumn: "UserTypeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_user_type_UserTypeID",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_users_UserTypeID",
                table: "users");

            migrationBuilder.AddColumn<int>(
                name: "UserTypeID1",
                table: "users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_users_UserTypeID1",
                table: "users",
                column: "UserTypeID1");

            migrationBuilder.AddForeignKey(
                name: "FK_users_user_type_UserTypeID1",
                table: "users",
                column: "UserTypeID1",
                principalTable: "user_type",
                principalColumn: "UserTypeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
