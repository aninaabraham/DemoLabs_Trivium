export { }

console.info("------------ DEMO: PROBLEM");

/**
 * Add two numbers OR concatenate two strings
 * 
 * @param a first parameter
 * @param b second parameters
 * @returns result
 */
function combine(a: any, b: any): any {
    return a + b;
}

/**** JavaScript version 
function combine2(a, b) {
    return a + b;
}
****/

console.log(combine(15, 20));               
console.log(combine("Hello ", "World"));
console.log('-----------------');

console.log(combine(15, " world"));
console.log(combine(15, null));           // Number(null) == 0,         15 + 0 == 15
console.log(combine(15, undefined));      // Number(undefined) == NaN.  15 + NaN == NaN
console.log(combine("15", undefined));    // undefined.ToString() == "undefined"
console.log(combine(true, true));
console.log(combine(false, false));
console.log('-----------------');

console.log(Number(null));
console.log(Number(undefined));
console.log('-----------------');
