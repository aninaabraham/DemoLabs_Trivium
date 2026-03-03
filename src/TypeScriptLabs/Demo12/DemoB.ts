export { };

console.info("------------ DEMO: Generic Class");

class MyGenericType<T> {
    constructor(public value: T) { }

    getValue(): T {
        return this.value;
    }
}

const stringBox = new MyGenericType<string>("Hello");
const numberBox = new MyGenericType<number>(123);

console.log(stringBox.getValue());
console.log(numberBox.getValue());