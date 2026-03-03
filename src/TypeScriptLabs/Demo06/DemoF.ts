export { };

console.info("------------ DEMO: Arrow Functions");

function subtractOld(a: number, b: number): number {
    return b - a;
}

const subtractNew = function (a: number, b: number) {
    // return b - a;
    // return "hello";
}

// "any" can be: void, PrimitiveType, Object
const subtractNew2 = function (a: number, b: number):any {
    // return b - a;
    // return "hello";
}

const dontReturnAnything = function (a: number, b: number):void {
    // return b - a;
    // return "hello";
}

const subtract = function (a: number, b: number):number {
    return b - a;
    // return "hello";     // error
}


const add = (a: number, b: number): number => {
    return a + b;
};

const run = () => 10;
const run2 = () => { return 10; }
run();
run2();


const multiply = (a: number, b: number): number => a * b;


console.log(add(5, 10));
console.log(multiply(20, 300));
console.log(typeof add);
