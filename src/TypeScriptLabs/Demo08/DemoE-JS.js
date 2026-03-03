console.info("------------ DEMO: JavaScript Symbol Type");

// JavaScript Symbol
// - is a primitive data type
// - is used to create unique, immutable identifiers, like object property keys to avoid naming collisions.


// DEMO 01: Basic Symbol Creation

const symbolVar1 = Symbol('anything here');
let symbolVar2 = Symbol('anything here');

console.log(symbolVar1 == symbolVar2);    // Output: false
console.log(symbolVar1 === symbolVar2);   // Output: false

console.log(typeof symbolVar1);           // Output: "symbol"
console.log(Symbol.keyFor(symbolVar1));   // Output: "undefined"
console.log(symbolVar1.description);      // Output: "anything here"
console.log('---------------------');



// DEMO 02: To share symbols across different parts, you can use the global symbol registry.
//          Register with Symbol.for() and retrieve their string key with Symbol.keyFor()

const globalSymbol1 = Symbol.for('description');
const globalSymbol2 = Symbol.for('description');

console.log(globalSymbol1 == globalSymbol2);      // Output: true  (they are the same shared symbol)
console.log(globalSymbol1 === globalSymbol2);     // Output: true  (they are the same shared symbol)
console.log(Symbol.keyFor(globalSymbol1));        // Output: "description"
console.log('---------------------');




// DEMO 03: Another example

const personId = Symbol('personId');
const person = {
    name: 'Jack',
    [personId]: 123         // Use the bracket notation for providing the symbol key
};

console.log(person.name);                       // Output: "Jack"
console.log(person.personId);                   // Output: undefined (dot notation looks for the string key 'personId')
console.log(person[personId]);                  // Output: 123
console.log(typeof person[personId]);           // Output: number
// console.log(person[name]);                   // RUN-TIME ERROR
console.log('---------------------');



// DEMO 04: An example of the built-in JavaScript "Symbol.Iterator"
//          An object's default iterator used by the for..of loops.

const myIterable = {
    [Symbol.iterator]: function* () { // A generator function makes it easy
        yield 1;
        yield 2;
        yield 3;
    }
};

for (const val of myIterable) {
    console.log(val);
}
// Output:
// 1
// 2
// 3
