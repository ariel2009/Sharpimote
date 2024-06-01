using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharpiMoteServer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CLIENTS",
                columns: table => new
                {
                    CLIENT_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IP_ADDR = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    CODE = table.Column<string>(type: "varchar(9)", nullable: false),
                    HASH = table.Column<byte[]>(type: "binary(256)", nullable: false)
                },
                constraints: table =>
                {
                    table.CheckConstraint("CK_IP_ADDR", "([IP_ADDR]>='1.0.0.1' AND [IP_ADDR]<='255.255.255.230')");
                    table.CheckConstraint("CK_CODE", "([CODE]>='001122334' AND [CODE]<='998877665')\r\n");
                    table.PrimaryKey("PK_CLIENTS", x => x.CLIENT_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CLIENTS");
        }
    }
}
