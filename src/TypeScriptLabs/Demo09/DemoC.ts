export { }

console.info("------------ DEMO: Class");

class Person {

    // instance members
    readonly id: number;            // access modifier is Public
    public name: string;
    age: number;

    // type members
    static readonly companyName: string = "Microsoft";

    constructor(id:number, name: string, age: number) {
        this.id = id;
        this.name = name;
        this.age = age;
    }

    greet(): string {
        return `Hello, I am ${this.name}, and my age is: ${this.age}.`;
    }
}

const person1 = new Person(10, "Manoj", 40);

console.log(person1.id);
console.log(person1.name);

console.log(person1.greet());

console.log(Person.companyName);