export { Employee };

/* =========================
   Employee Class
========================= */

class Employee {


    constructor(
        public readonly employeeID: number,
        public employeeName: string,
        public designation: string
    ) { }


    toString(): string {
        return `ID: ${this.employeeID}, Name: ${this.employeeName}, Designation: ${this.designation}`;
    }

}


