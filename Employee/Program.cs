using Employee.Core.Admins.Implementation;
using Employee.Core.Admins.Interface;
using Employee.Core.Employees.Implementation;
using Employee.Core.Employees.Interface;
using Employee.Core.LeaveApprovals.Implementation;
using Employee.Core.LeaveApprovals.Interface;
using Employee.Core.LeaveRequests.Implementation;
using Employee.Core.LeaveRequests.Interface;
using Employee.Core.LogInValidation;
using Employee.Core.LogInValidation.Admins;
using Employee.Core.Salaries.Implementation;
using Employee.Core.Salaries.Interface;
using Employee.Core.StatusCore.Implementation;
using Employee.Core.StatusCore.Interface;
using Employee.Infrastructure.PracticeDbContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connection = builder.Configuration.GetConnectionString("EmployeeDb");
builder.Services.AddDbContext<EmployeeDbContext>(option => option.UseSqlServer(connection));

//Employee
builder.Services.AddScoped<IEmployeeDetailsCreator, EmployeeDetailsCreator>();
builder.Services.AddScoped<IEmployeeDetailsUpdator, EmployeeDetailsUpdator>();
builder.Services.AddScoped<IEmployeeDetailsDeletor, EmployeeDetailsDeletor>();
builder.Services.AddScoped<IEmployeeDetailsInformation, EmployeeDetailsInformation>();

//Salary
builder.Services.AddScoped<IEmployeeSalaryCreator, EmployeeSalaryCreator>();
builder.Services.AddScoped<IEmployeeSalaryUpdator, EmployeeSalaryUpdator>();
builder.Services.AddScoped<IEmployeeSalaryDeletor, EmployeeSalaryDeletor>();
builder.Services.AddScoped<IEmployeeSalaryInformation, EmployeeSalaryInformation>();
builder.Services.AddScoped<IEmployeeSalaryDetailsGet,  EmployeeSalaryDetailsGet>();

//Login
builder.Services.AddScoped<ILoginEmployeeDetails, LoginEmployeeDetails>();
builder.Services.AddScoped<IAdminLoginDetails,  AdminLoginDetails>();   

//Status
builder.Services.AddScoped<IStatusCreator,  StatusCreator>();

//Admin
builder.Services.AddScoped<IAdminCreator,  AdminCreator>();

//LeaveRequest
builder.Services.AddScoped<ILeaveRequestCreator, LeaveRequestCreator>();
builder.Services.AddScoped<ILeaveRequestInformation, LeaveRequestInformation>();
builder.Services.AddScoped<ILeaveRequestInformationById, LeaveRequestInformationById>();
builder.Services.AddScoped<ILeaveRequestUpdator, LeaveRequestUpdator>();
builder.Services.AddScoped<ILeaveRequestStatusCountor,  LeaveRequestStatusCountor>();
builder.Services.AddScoped<ILeaveRequestInformationByDate,  LeaveRequestInformationByDate>();

//LeaveApproved
builder.Services.AddScoped<ILeaveApprovalCreator,  LeaveApprovalCreator>();
builder.Services.AddScoped<ILeaveApprovalInformation, LeaveApprovalInformation>();
builder.Services.AddScoped<ILeaveApprovalInformationById, LeaveApprovalInformationById>();
builder.Services.AddScoped<ILeaveApprovalInformationByRequestId, LeaveApprovalInformationByRequestId>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
