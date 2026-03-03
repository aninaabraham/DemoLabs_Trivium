export { }

console.info("------------ DEMO: Unions vs Overloads");


// ---------- UNION version

function doSomething(value: string | number): void {
}


// ---------- OVERLOAD version
// PURPOSE: to ensure that while calling the function, no invalid parameters

function getLength(value: string): number;
function getLength(value: any[]): number;

function getLength(value: string | any[]): number {
    return 0;
}

