// See https://aka.ms/new-console-template for more information
using Interface_Segregation_Principle;


IEmployee employee =new PartTimeEmployee();

employee.getSalary();


IEmployee employee2 = new PermanentEmployee();
employee2.getSalary();

IProfitShareEmployee profitShareEmployee = new PermanentEmployee();
profitShareEmployee.CalculateProfitShare();
