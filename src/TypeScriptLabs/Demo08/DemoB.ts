export { }

console.info("------------ DEMO: Why Restrictions Exist");


/**********
    PROBLEM:
    function print(value: string | number) {
        console.log(value.length);                  //   Error 
    }
***********/

// SOLUTION: Type Narrowing with typeof

function print(value: string | number) {
    if (typeof value === "string") {
        console.log("String length:", value.length);
    } else {
        console.log("Number fixed:", value.toFixed(2));
    }
}

print("Hello");
print(10);


// SOLUTION: Type Narrowing with instanceof
//           NOTE: instanceof works with Objects
//                 typeof     works with primitives
// let dt = new Date();                // instanceof
// let i: number = 10;                 // typeof

function format(value: Date | string) {
    if (value instanceof Date) {
        console.log("ISO:", value.toISOString());
    } else {
        console.log("Upper:", value.toUpperCase());
    }
}

format(new Date());
format("hello");



// SOLUTION: A version without narrowing:
//           NOTE: will work with only shared members of the types.
function getString(value: string | number) {
    return value.toString();            // allowed since it is common to both
}

