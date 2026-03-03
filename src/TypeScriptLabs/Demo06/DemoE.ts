export { };

console.info("------------ DEMO: Combining Default and Optional Parameters");

/**
 * Greets a user by name.
 * 
 * @param name - The name of the person to greet.
 * @isEnable - Is Enabled (OPTIONAL)
 * @param age - age of the person (DEFAULT: 25).
 * @returns A formatted greeting message.
 */
function greet(
    name: string,
    isEnabled?: boolean,
    age: number = 25)
: string {
    if (isEnabled) {
        return `Hello ${name}, you are ${age} years old.  ACCESS GRANTED!`;
    }
    return `Hello ${name}.  ACCESS DENIED`;
}


console.log(greet("Manoj"));
console.log(greet("Manoj", true));
console.log(greet("Manoj", false, 50));
console.log(greet("Manoj", true, 50));
console.log(greet("Manoj", undefined, 50));
