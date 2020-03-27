﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace leave_management.Data.Migrations
{
    public partial class AddedLeaveDetailsTables1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAllocations_leaveTypes_LeaveTypeId",
                table: "LeaveAllocations");

            migrationBuilder.DropForeignKey(
                name: "FK_leaveHistories_AspNetUsers_ApprovedById",
                table: "leaveHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_leaveHistories_leaveTypes_LeaveTypeId",
                table: "leaveHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_leaveHistories_AspNetUsers_RequestingEmployeeId",
                table: "leaveHistories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_leaveTypes",
                table: "leaveTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_leaveHistories",
                table: "leaveHistories");

            migrationBuilder.RenameTable(
                name: "leaveTypes",
                newName: "LeaveTypes");

            migrationBuilder.RenameTable(
                name: "leaveHistories",
                newName: "LeaveHistories");

            migrationBuilder.RenameIndex(
                name: "IX_leaveHistories_RequestingEmployeeId",
                table: "LeaveHistories",
                newName: "IX_LeaveHistories_RequestingEmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_leaveHistories_LeaveTypeId",
                table: "LeaveHistories",
                newName: "IX_LeaveHistories_LeaveTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_leaveHistories_ApprovedById",
                table: "LeaveHistories",
                newName: "IX_LeaveHistories_ApprovedById");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeaveTypes",
                table: "LeaveTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeaveHistories",
                table: "LeaveHistories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveAllocations_LeaveTypes_LeaveTypeId",
                table: "LeaveAllocations",
                column: "LeaveTypeId",
                principalTable: "LeaveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveHistories_AspNetUsers_ApprovedById",
                table: "LeaveHistories",
                column: "ApprovedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveHistories_LeaveTypes_LeaveTypeId",
                table: "LeaveHistories",
                column: "LeaveTypeId",
                principalTable: "LeaveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveHistories_AspNetUsers_RequestingEmployeeId",
                table: "LeaveHistories",
                column: "RequestingEmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAllocations_LeaveTypes_LeaveTypeId",
                table: "LeaveAllocations");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveHistories_AspNetUsers_ApprovedById",
                table: "LeaveHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveHistories_LeaveTypes_LeaveTypeId",
                table: "LeaveHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveHistories_AspNetUsers_RequestingEmployeeId",
                table: "LeaveHistories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeaveTypes",
                table: "LeaveTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeaveHistories",
                table: "LeaveHistories");

            migrationBuilder.RenameTable(
                name: "LeaveTypes",
                newName: "leaveTypes");

            migrationBuilder.RenameTable(
                name: "LeaveHistories",
                newName: "leaveHistories");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveHistories_RequestingEmployeeId",
                table: "leaveHistories",
                newName: "IX_leaveHistories_RequestingEmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveHistories_LeaveTypeId",
                table: "leaveHistories",
                newName: "IX_leaveHistories_LeaveTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveHistories_ApprovedById",
                table: "leaveHistories",
                newName: "IX_leaveHistories_ApprovedById");

            migrationBuilder.AddPrimaryKey(
                name: "PK_leaveTypes",
                table: "leaveTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_leaveHistories",
                table: "leaveHistories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveAllocations_leaveTypes_LeaveTypeId",
                table: "LeaveAllocations",
                column: "LeaveTypeId",
                principalTable: "leaveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_leaveHistories_AspNetUsers_ApprovedById",
                table: "leaveHistories",
                column: "ApprovedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_leaveHistories_leaveTypes_LeaveTypeId",
                table: "leaveHistories",
                column: "LeaveTypeId",
                principalTable: "leaveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_leaveHistories_AspNetUsers_RequestingEmployeeId",
                table: "leaveHistories",
                column: "RequestingEmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
