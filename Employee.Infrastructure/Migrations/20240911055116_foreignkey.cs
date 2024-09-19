using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Employee.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class foreignkey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequest_AdminId",
                table: "LeaveRequest",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequest_EmployeeDetailsId",
                table: "LeaveRequest",
                column: "EmployeeDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequest_StatusId",
                table: "LeaveRequest",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveApproval_LeaveRequestId",
                table: "LeaveApproval",
                column: "LeaveRequestId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveApproval_LeaveRequest_LeaveRequestId",
                table: "LeaveApproval",
                column: "LeaveRequestId",
                principalTable: "LeaveRequest",
                principalColumn: "LeaveRequestId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveRequest_Admin_AdminId",
                table: "LeaveRequest",
                column: "AdminId",
                principalTable: "Admin",
                principalColumn: "AdminId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveRequest_EmployeeDetails_EmployeeDetailsId",
                table: "LeaveRequest",
                column: "EmployeeDetailsId",
                principalTable: "EmployeeDetails",
                principalColumn: "EmployeeDetailsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveRequest_Status_StatusId",
                table: "LeaveRequest",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveApproval_LeaveRequest_LeaveRequestId",
                table: "LeaveApproval");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveRequest_Admin_AdminId",
                table: "LeaveRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveRequest_EmployeeDetails_EmployeeDetailsId",
                table: "LeaveRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveRequest_Status_StatusId",
                table: "LeaveRequest");

            migrationBuilder.DropIndex(
                name: "IX_LeaveRequest_AdminId",
                table: "LeaveRequest");

            migrationBuilder.DropIndex(
                name: "IX_LeaveRequest_EmployeeDetailsId",
                table: "LeaveRequest");

            migrationBuilder.DropIndex(
                name: "IX_LeaveRequest_StatusId",
                table: "LeaveRequest");

            migrationBuilder.DropIndex(
                name: "IX_LeaveApproval_LeaveRequestId",
                table: "LeaveApproval");
        }
    }
}
