export { }

console.info("------------ DEMO: Better Implementation (Using Union + Narrowing)");

function combine(a: number, b: number): number;
function combine(a: string, b: string): string;


// --- The implementation of the overloaded definitions:
// NOTE: Union Type must be compatible with all overloads.
function combine(
    a: number | string,
    b: number | string)
{
    if (typeof a === "number" && typeof b === "number") {
        return a + b;
    }
    if (typeof a === "string" && typeof b === "string") {
        return a + b;
    }
    throw new Error("Invalid arguments");
}

console.log(combine(10, 20));
console.log(combine("Hello ", "World"));
console.log('---------');

// console.log(combine(15, " world"));    // will throw error ONLY IF OVERLOAD prototypes defined
// console.log(combine("hello", 15));     // will throw error ONLY IF OVERLOAD prototypes defined
// console.log('---------');

//console.log(combine(15, null));
//console.log(combine(15, undefined));
//console.log(combine("15", undefined));
//console.log(combine(true, true));
//console.log(combine(false, false));


// ----------------------- Another Example


// --- The overloads describing the Contract
function format(value: number): string;
function format(value: Date): string;


// --- The implementation of the overloaded definitions:
function format(value: number | Date): string {
    if (typeof value === "number") {
        return value.toFixed(2);
    }
    return value.toISOString();
}

console.log(format(10));
console.log(format(new Date()));
