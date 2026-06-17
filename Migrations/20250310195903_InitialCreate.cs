using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Exam_System.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f91bba9b-d7e8-476e-8f32-12c0a71b6f31", "AQAAAAIAAYagAAAAEN8pzL2TFKkBmAevqRIOjdCTKtC/HHyT2W/0iQ40Pchz3Ne1JzuAM1D/RajCvaLlSg==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "01f8c25d-9a59-4791-b517-a950f1c589e4", "AQAAAAIAAYagAAAAEJl+wDAO1gKKCJhSfEGluGMq9di7oersJuQ7BgIWenhVi8b6OG6ZlGgrVFtinVe6iQ==" });
        }
    }
}
