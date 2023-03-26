using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication6.Migrations
{
    public partial class qedir : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BanNövü = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yürüş = table.Column<int>(type: "int", nullable: false),
                    OlcuVahidi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rəng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qiymet = table.Column<int>(type: "int", nullable: false),
                    PulVahidi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasinSahibiSayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yerlerinsayi = table.Column<int>(type: "int", nullable: false),
                    YanacağNövü = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ötürücü = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SürətlərQutusu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    İl = table.Column<int>(type: "int", nullable: false),
                    MühHəcmi = table.Column<int>(type: "int", nullable: false),
                    MühGücü = table.Column<int>(type: "int", nullable: false),
                    Bazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VinKod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ƏlavəMəlumat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vəziyəti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvtoTəchizatı = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kredit = table.Column<bool>(type: "bit", nullable: false),
                    Barter = table.Column<bool>(type: "bit", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Şəhər = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
