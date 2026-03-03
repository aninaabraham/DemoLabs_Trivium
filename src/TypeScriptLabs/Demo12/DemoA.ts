export { };

console.info("------------ DEMO: Generic Function");

/******* PROBLEM: No type safety *******/

function DoSomething(value: any): any {
    return value;
}

let result = DoSomething("Hello");          // result:any


/******* Solution: Generics offers TypeSafety *******/

function MyDemo<T>(value: T): T {
    return value;
}

let result1 = MyDemo<string>("Hello");      // result1: string
let result2 = MyDemo<number>(100);          // result2: number

console.log(result1);
console.log(result2);



/***************** Another Example ***************/

function getFirstElement<T>(arr: T[]): T {
    return arr[0];
}

console.log(getFirstElement([1, 2, 3]));
console.log(getFirstElement(["a", "b", "c"]));

