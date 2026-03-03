export { };

console.info("------------ DEMO: Default Parameters");

/**
 * Greets a user by name.
 * 
 * @param name - The name of the person to greet.
 * @param age -  age of the person with DEFAULT: 25.  (is OPTIONAL)
 * @returns A formatted greeting message.
 */
function greet(
    name: string,
    age: number = 25,
    isEnabled: boolean)
: string {
    console.log(`Received age: ${age}`);
    if (age) {
        return `Hello ${name}, you are ${age} years old`;
    }
    return `Hello ${name}`;
}


/****
    function greet2(name: string, age?: number = 25): string {                 // This is INVALID
        // ...
    } 
*****/

console.log(greet("Manoj", 5, true));
console.log(greet("Manoj", undefined, true));
console.log(greet("Manoj", 25, false));
