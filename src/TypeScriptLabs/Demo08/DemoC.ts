export { }

console.info("------------ DEMO: Why Restrictions Exist");


// ----------- The TYPEOF Version (shown in DemoB.ts)
function print(value: string | number) {
    if (typeof value === "string") {
        console.log("String length:", value.length);
    } else {
        console.log("Number fixed:", value.toFixed(2));
    }
}

print("Hello");
print(10);
console.log('-------------------');


// ----------- PROBLEM: The INSTANCEOF Version
// NOTE: instanceof works with Objects
//       typeof     works with primitives

/*****
function print2(value: string | number) {
    if (value instanceof string) {                            // ERROR!   string is an Object, not Primitive
        console.log("String length:", value.length);
    } else {
        console.log("Number fixed:", value.toFixed(2));
    }
}
****/

// To understand:

console.log(typeof "Hello");                            // string
// console.log("Hello" instanceof String);              // ERROR
console.log(new String("Hello") instanceof String);     // true
console.log('-------------------');


/*************************
    There are 7 PRIMITIVES:
    string, number, boolean, bigint, symbol, undefined, null

    Characteristics of Primitives:
    - Stored directly as values
    - Immutable
    - NOT objects
    - Checked using typeof (except null, special case)

    Characteristics of Objects:
    - Stored by reference
    - Mutable
    - Created using constructors (new String("Hello")) or literals "Hello"
    - Checked using instanceof
 */
console.log(typeof "Hello");      // string
console.log(typeof 123);          // number
console.log(typeof true);         // boolean
console.log(typeof 10n);          // bigint
console.log(typeof Symbol());     // symbol
console.log(typeof undefined);    // undefined
console.log(typeof null);         // object (a historical bug from 1995!)
console.log('-------------------');

console.log([] instanceof Array);           // true
console.log(new Date() instanceof Date);    // true
console.log({} instanceof Object);          // true
console.log('-------------------');

let x = "Hello";
let y = new String("Hello");

// console.log(x instanceof String);    // ERROR
console.log(typeof x === "string");     // true

console.log(y instanceof String);       // true
console.log(typeof y === "string");     // false
console.log('-------------------');




// To identify if Primitive Vs. Object, check at runtime

function isPrimitive(value: any): boolean {
    // return ! (value === Object(value) );
    return value !== Object(value);
}

