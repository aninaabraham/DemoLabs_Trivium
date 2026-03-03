import { Employee } from './Employee';
export { Company };

/* =========================
   Company Class
========================= */

class Company {

    private employeesCollection = new Map<number, Employee>();


    constructor(public companyName: string) { }


    // Method-based add
    addEmployee(employee: Employee): void {
        this.employeesCollection.set(employee.employeeID, employee);
    }


    // Method-based get
    getEmployee(employeeID: number): Employee | undefined {
        return this.employeesCollection.get(employeeID);
    }


    // Getter for employee count
    get employeeCount(): number {
        return this.employeesCollection.size;
    }


    // Optional getter returning iterable collection
    get employees(): Iterable<Employee> {
        return this.employeesCollection.values();
    }

}
