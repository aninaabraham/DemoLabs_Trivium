export { };

console.info("------------ DEMO: Interface");

interface IEmployee {
    id: number;
    name: string;
    designation: string;
}

interface IPrintable {
    toString(): string;
}


class Employee implements IEmployee, IPrintable {

    public salary: number;

    constructor(
        public id: number,
        public name: string,
        public designation: string
    ) {
        this.salary = 500;
    }


    toString(): string {
        return `ID: ${this.id}, Name: ${this.name}, Designation: ${this.designation}`;
    }

}


let emp1: Employee = new Employee(10, 'first employee', 'ceo');
console.log(emp1);
console.log(emp1.toString());
console.log();

// let emp2: IEmployee = new IEmployee(20, 'second employee', 'manager');

// NOTE: In TypeScript, interfaces are "structural", not "nominal"
//       meaning, TypeScript only checks for the structure, not the name
let emp2: IEmployee = {
    id: 20,
    name: 'second employee',
    designation: 'manager',
}
console.log(emp2);