using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class createDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("18e706cf-5fd2-49f9-93c4-1a1314f665a0"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Role", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("3357c78a-8528-49f0-aa52-7d19a5f65fba"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System", "example@example.com", "Admin", "Admin", new byte[] { 98, 30, 138, 160, 220, 255, 191, 160, 10, 114, 228, 220, 1, 167, 220, 245, 243, 209, 27, 243, 245, 118, 230, 253, 92, 212, 101, 64, 81, 45, 59, 93, 176, 7, 209, 138, 101, 132, 198, 33, 39, 218, 70, 251, 110, 120, 145, 220, 255, 90, 87, 255, 169, 254, 74, 109, 221, 130, 245, 41, 137, 25, 107, 5 }, new byte[] { 130, 79, 145, 242, 90, 34, 196, 104, 169, 31, 5, 9, 106, 46, 98, 86, 69, 155, 3, 175, 215, 73, 221, 155, 18, 4, 10, 141, 78, 136, 16, 78, 66, 32, 63, 207, 56, 221, 118, 193, 223, 229, 253, 156, 224, 54, 191, 15, 215, 162, 247, 74, 107, 32, 112, 185, 18, 240, 245, 55, 81, 98, 34, 132, 146, 227, 61, 130, 31, 122, 172, 156, 183, 98, 152, 190, 94, 186, 122, 151, 156, 207, 78, 254, 233, 44, 18, 104, 142, 85, 16, 56, 98, 187, 57, 150, 200, 253, 95, 109, 124, 152, 76, 249, 166, 109, 3, 123, 2, 18, 231, 25, 243, 40, 10, 152, 18, 134, 21, 236, 179, 33, 179, 137, 36, 93, 23, 89 }, "Admin", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3357c78a-8528-49f0-aa52-7d19a5f65fba"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Role", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("18e706cf-5fd2-49f9-93c4-1a1314f665a0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System", "example@example.com", "Admin", "Admin", new byte[] { 2, 58, 173, 242, 90, 200, 246, 165, 110, 134, 128, 46, 213, 156, 93, 191, 97, 16, 250, 48, 120, 17, 42, 86, 192, 178, 186, 66, 154, 181, 210, 99, 38, 121, 107, 246, 216, 42, 0, 137, 191, 135, 0, 157, 219, 53, 47, 246, 10, 113, 90, 169, 25, 38, 206, 8, 142, 32, 86, 61, 156, 148, 178, 220 }, new byte[] { 154, 133, 69, 120, 84, 65, 218, 83, 231, 0, 116, 14, 175, 198, 33, 250, 229, 154, 162, 60, 255, 180, 11, 192, 0, 79, 5, 49, 10, 250, 133, 246, 186, 186, 32, 65, 225, 15, 101, 226, 239, 249, 50, 95, 255, 60, 113, 250, 235, 175, 62, 248, 43, 65, 181, 85, 158, 227, 244, 153, 214, 190, 22, 38, 61, 197, 77, 188, 114, 172, 100, 161, 5, 73, 162, 5, 209, 167, 153, 5, 15, 177, 22, 87, 169, 153, 223, 38, 130, 18, 233, 77, 169, 39, 34, 26, 71, 40, 2, 194, 121, 5, 204, 157, 80, 218, 212, 88, 217, 17, 186, 175, 228, 135, 0, 19, 75, 198, 179, 139, 103, 21, 203, 52, 64, 142, 184, 153 }, "Admin", null, null });
        }
    }
}
