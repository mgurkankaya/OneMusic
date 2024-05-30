using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneMusic.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_singer_table_removed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Singers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Singers",
                columns: table => new
                {
                    SingerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Singers", x => x.SingerId);
                });
        }
    }
}
