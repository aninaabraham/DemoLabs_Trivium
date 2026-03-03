import { Company } from './Company';
import { Employee } from './Employee';


const company = new Company("Microsoft");

company.addEmployee(new Employee(101, "Manoj", "Architect"));
company.addEmployee(new Employee(102, "Mahesh", "Developer"));
company.addEmployee(new Employee(103, "Ramya", "QA Engineer"));

console.log("Total Employees:", company.employeeCount);


// Get single employee
const emp = company.getEmployee(101);
console.log(emp?.toString());

// Iterate through all the employees in the company
for (const employee of company.employees) {
    console.log(employee.toString());
}
