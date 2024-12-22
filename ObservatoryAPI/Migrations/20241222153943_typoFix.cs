using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ObservatoryAPI.Migrations
{
    /// <inheritdoc />
    public partial class typoFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SceduledTime",
                table: "Observations",
                newName: "ScheduledTime");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ScheduledTime",
                table: "Observations",
                newName: "SceduledTime");
        }
    }
}
