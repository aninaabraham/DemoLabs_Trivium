export { };

console.info("------------ DEMO: Basic Typed Function - Parameter + Return Type");

function greet(name: string): string {
    return `Hello, ${name}`;
}

function add(a: number, b: number): number {
    return a + b;
}


let message = greet("Manoj");
console.log(message);

console.log(`Sum of ${10} and ${20} = ${add(10, 20)}`);