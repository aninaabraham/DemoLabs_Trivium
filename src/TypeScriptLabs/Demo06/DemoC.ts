export { };

console.info("------------ DEMO: Optional Parameters + JSDoc Documentation");

/**
 * Greets a user by name.
 * 
 * @param name - The name of the person to greet.
 * @param age - OPTIONAL age of the person.
 * @returns A formatted greeting message.
 */
function greet(name: string, age?: number): string {
    if (age) {
        return `Hello ${name}, you are ${age} years old`;
    }
    return `Hello ${name}`;
}


console.log(greet("Manoj"));
console.log(greet("Manoj", 0));                 // "Hello Manoj"
console.log(greet("Manoj", 25));