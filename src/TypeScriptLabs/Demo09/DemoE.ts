export { }

console.info("------------ DEMO: Inheritance");

/***
 * NOTE: You will need to compile this TypeScript file to its JS version, and run!
 *       NODE does not understand Advanced TypeScript syntax
 *       Eg: Inheritance
 */


class Person {

    constructor(public name: string) { }

    greet() {
        return `Hello, I am ${this.name}`;
    }

}



class Employee extends Person {

    constructor(name: string, public role: string) {
        super(name);
    }

    describe() {
        return `${this.name} works as ${this.role}`;
    }

    greet() {
        return "hello world";
    }

}


const emp = new Employee("Manoj Kumar Sharma", "Architect");

console.log(emp.greet());
console.log(emp.describe());

const person: Person = new Employee("Second Employee", "manager");
person.greet();
// person.describe();


