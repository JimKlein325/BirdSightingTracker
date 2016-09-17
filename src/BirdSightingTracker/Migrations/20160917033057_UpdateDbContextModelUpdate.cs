using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BirdSightingTracker.Migrations
{
    public partial class UpdateDbContextModelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Birds",
                columns: table => new
                {
                    BirdId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CommonName = table.Column<string>(nullable: true),
                    ConservationCode = table.Column<string>(nullable: true),
                    ConservationStatus = table.Column<string>(nullable: true),
                    Family = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    PrimaryColor = table.Column<string>(nullable: true),
                    ScientificName = table.Column<string>(nullable: true),
                    SecondaryColor = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    Weight = table.Column<double>(nullable: false),
                    Width = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Birds", x => x.BirdId);
                });

            migrationBuilder.CreateTable(
                name: "BirdColor",
                columns: table => new
                {
                    ColorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BirdId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BirdColor", x => x.ColorId);
                    table.ForeignKey(
                        name: "FK_BirdColor_Birds_BirdId",
                        column: x => x.BirdId,
                        principalTable: "Birds",
                        principalColumn: "BirdId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    PlaceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BirdId = table.Column<int>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Climate = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    TerrainType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.PlaceId);
                    table.ForeignKey(
                        name: "FK_Places_Birds_BirdId",
                        column: x => x.BirdId,
                        principalTable: "Birds",
                        principalColumn: "BirdId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sightings",
                columns: table => new
                {
                    SightingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BirdId = table.Column<int>(nullable: true),
                    ObserverFirstName = table.Column<string>(nullable: true),
                    ObserverLastName = table.Column<string>(nullable: true),
                    PlaceId = table.Column<int>(nullable: true),
                    SightingDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sightings", x => x.SightingId);
                    table.ForeignKey(
                        name: "FK_Sightings_Birds_BirdId",
                        column: x => x.BirdId,
                        principalTable: "Birds",
                        principalColumn: "BirdId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sightings_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "PlaceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BirdColor_BirdId",
                table: "BirdColor",
                column: "BirdId");

            migrationBuilder.CreateIndex(
                name: "IX_Places_BirdId",
                table: "Places",
                column: "BirdId");

            migrationBuilder.CreateIndex(
                name: "IX_Sightings_BirdId",
                table: "Sightings",
                column: "BirdId");

            migrationBuilder.CreateIndex(
                name: "IX_Sightings_PlaceId",
                table: "Sightings",
                column: "PlaceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BirdColor");

            migrationBuilder.DropTable(
                name: "Sightings");

            migrationBuilder.DropTable(
                name: "Places");

            migrationBuilder.DropTable(
                name: "Birds");
        }
    }
}
