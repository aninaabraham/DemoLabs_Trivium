export { }

console.info("------------ DEMO: SOLUTION: Overloaded Functions");

/**
 * Combines two numbers or two strings.
 */
function combine(a: number, b: number): number;
function combine(a: string, b: string): string;


// Implementation signature
function combine(a: any, b: any): any {
    return a + b;
}

console.log(combine(10, 20));
console.log(combine("Hello ", "World"));

/********
console.log(combine(15, " world"));
console.log(combine(15, null));
console.log(combine(15, undefined));
console.log(combine("15", undefined));
console.log(combine(true, true));
console.log(combine(false, false));
*****/
