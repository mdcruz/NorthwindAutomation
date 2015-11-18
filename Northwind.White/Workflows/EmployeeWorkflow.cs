﻿using Northwind.White.ScreenObjects;
using Northwind.White.TestData;
using TestStack.White;

namespace Northwind.White.Workflows
{
    public class EmployeeWorkflow
    {
        public static void AddNewEmployee(MainWindow mainWindow, EmployeeDetails employeeDetails, Application application) 
        {
            mainWindow.AddEmployee();
            var newEmployeeWindow = new NewEmployeeWindow(application);
            newEmployeeWindow.AddNewEmployee(employeeDetails).AssignToDepartment(new DepartmentDetails().TestDepartmentName);
            new EmployeeRecordWindow(application).ClickOk();
        }
    }
}