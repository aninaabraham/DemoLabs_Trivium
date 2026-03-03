export { }

/***
 * NOTE: You will need to compile this TypeScript file to its JS version, and run!
 *       NODE does not understand Advanced TypeScript syntax
 *       Eg: Parameter Constructor Version
 */

console.info("------------ DEMO: Class with Parameter Properties");

class Person {
    name: string;
    private age: number;

    constructor(name: string, age: number) {
        this.name = name;
        this.age = age;
    }
}

var p1 = new Person("Manoj Sharma", 25);


/***
 * Parameter Constructor Version
 */
class Person2 {
    constructor(
        public name: string,
        private age: number
    ) { }

    getAge() {
        return this.age;
    }

    toString() {
        return `Name: ${this.name} Age: {this.age}`;
    }
}

var p2 = new Person2("Manoj Sharma", 25);
console.log(p2);