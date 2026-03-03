export { }

console.info("------------ DEMO: Getters and Setters");

/***
 * NOTE: You will need to compile this TypeScript file to its JS version, and run!
 *       NODE does not understand Advanced TypeScript syntax
 *       Eg: Getters and Setters
 */


/****
 * PROBLEM: exposing properties does not offer encapsulated logic.
 */

class Person {
    public name: string;

    constructor(name: string) {
        this.name = name;
    }
}

const p = new Person("Manoj");
p.name = "";               // Direct modification - no validation! -no encapsultion!
console.log(p.name);


/****
 * SOLUTION: Use Getters and Setters to implement encapsulation.
 */

class Person2 {
    private _name: string;

    constructor(name: string) {
        this._name = name;
    }

    get name(): string {
        return this._name;
    }

    set name(value: string) {
        if (value.length < 2) {
            throw new Error("Name must be at least 2 characters long.");
        }
        this._name = value;
    }
}

const p2 = new Person2("Manoj");

console.log(p2.name);   // Calls the getter
p2.name = "";           // Calls the setter

