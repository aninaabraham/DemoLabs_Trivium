export { }

console.info("------------ DEMO: Inheritance with PROTECTED members");

/***
 * NOTE: You will need to compile this TypeScript file to its JS version, and run!
 *       NODE does not understand Advanced TypeScript syntax
 *       Eg: Inheritance
 */


class Person {
    constructor(protected name: string) { }
}

class Employee extends Person {
    printName() {
        console.log(this.name); 
    }
}


const emp = new Employee("Manoj Kumar Sharma");
emp.printName();

