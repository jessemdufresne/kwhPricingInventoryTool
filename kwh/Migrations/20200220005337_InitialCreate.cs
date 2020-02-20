using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace kwh.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Maturity",
                columns: table => new
                {
                    MaturityId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MaturityStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maturity", x => x.MaturityId);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    ProjectId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProjectName = table.Column<string>(nullable: true),
                    ProjectYear = table.Column<int>(nullable: false),
                    ProjectCountry = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.ProjectId);
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    VendorId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    VendorName = table.Column<string>(nullable: true),
                    VendorUrl = table.Column<string>(nullable: true),
                    VendorPhone = table.Column<string>(nullable: true),
                    VendorEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.VendorId);
                });

            migrationBuilder.CreateTable(
                name: "Volunteer",
                columns: table => new
                {
                    VolunteerId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    VolunteerPhone = table.Column<string>(nullable: true),
                    VolunteerEmail = table.Column<string>(nullable: true),
                    PIN = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volunteer", x => x.VolunteerId);
                });

            migrationBuilder.CreateTable(
                name: "Component",
                columns: table => new
                {
                    ComponentId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Historic = table.Column<int>(nullable: false),
                    Current = table.Column<int>(nullable: false),
                    VendorId = table.Column<int>(nullable: false),
                    VolunteerId = table.Column<int>(nullable: false),
                    MaturityId = table.Column<int>(nullable: false),
                    ProjectId = table.Column<int>(nullable: false),
                    PartNumber = table.Column<string>(nullable: true),
                    PartName = table.Column<string>(nullable: true),
                    UnitCost = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Specification = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    QuantityCurrent = table.Column<int>(nullable: false),
                    QuantityNeeded = table.Column<int>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Component", x => x.ComponentId);
                    table.ForeignKey(
                        name: "FK_Component_Maturity_MaturityId",
                        column: x => x.MaturityId,
                        principalTable: "Maturity",
                        principalColumn: "MaturityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Component_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Component_Vendor_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendor",
                        principalColumn: "VendorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Component_Volunteer_VolunteerId",
                        column: x => x.VolunteerId,
                        principalTable: "Volunteer",
                        principalColumn: "VolunteerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Component_MaturityId",
                table: "Component",
                column: "MaturityId");

            migrationBuilder.CreateIndex(
                name: "IX_Component_ProjectId",
                table: "Component",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Component_VendorId",
                table: "Component",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_Component_VolunteerId",
                table: "Component",
                column: "VolunteerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Component");

            migrationBuilder.DropTable(
                name: "Maturity");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Vendor");

            migrationBuilder.DropTable(
                name: "Volunteer");
        }
    }
}
