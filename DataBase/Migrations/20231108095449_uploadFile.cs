﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBase.Migrations
{
    /// <inheritdoc />
    public partial class uploadFile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Engagement_Country_CountyId",
                table: "Engagement");

            migrationBuilder.DropIndex(
                name: "IX_Engagement_CountyId",
                table: "Engagement");

            migrationBuilder.RenameColumn(
                name: "ClinetName",
                table: "Engagement",
                newName: "EngagementStartDate");

            migrationBuilder.AddColumn<string>(
                name: "ClientName",
                table: "Engagement",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EngagementEndDate",
                table: "Engagement",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Attachment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MimeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileContent = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuditMaster",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuditName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditMaster", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attachment");

            migrationBuilder.DropTable(
                name: "AuditMaster");

            migrationBuilder.DropColumn(
                name: "ClientName",
                table: "Engagement");

            migrationBuilder.DropColumn(
                name: "EngagementEndDate",
                table: "Engagement");

            migrationBuilder.RenameColumn(
                name: "EngagementStartDate",
                table: "Engagement",
                newName: "ClinetName");

            migrationBuilder.CreateIndex(
                name: "IX_Engagement_CountyId",
                table: "Engagement",
                column: "CountyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Engagement_Country_CountyId",
                table: "Engagement",
                column: "CountyId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
