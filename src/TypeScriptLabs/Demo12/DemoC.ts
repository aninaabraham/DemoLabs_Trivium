export { };

console.info("------------ DEMO: Generic with Constraints");

// Ensure that the type "T"" has a "Length" property
function printLength<T extends { length: number }>(value: T): void {
    console.log(value.length);
}

printLength("Hello");
printLength([1, 2, 3]);
// printLength(100);            // Error

