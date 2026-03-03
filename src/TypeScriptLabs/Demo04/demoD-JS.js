console.info("------------ DEMO: Nullish Coalescing Operator `??`");


let message;
let testLet = message ?? 'default value';

console.log(testLet);                               // "default value"



let value1 = null;
let value2 = undefined;
let value3 = "";
let value4 = 0;

console.log(value1 ?? "default");                   // default (loose equality)
console.log(value2 ?? "default");                   // default (loose equality)
console.log(value3 ?? "default");                   // "" (NOT default)
console.log(value4 ?? "default");                   // 0 (NOT default)

console.log(value1 == true);                        // false
console.log(value2 == true);                        // false
console.log(value3 == true);                        // false
console.log(value4 == true);                        // false

console.log(value1 === true);                       // false
console.log(value2 === true);                       // false
console.log(value3 === true);                       // false
console.log(value4 === true);                       // false
