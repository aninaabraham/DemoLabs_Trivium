console.info("------------ DEMO: Scope Difference");

export { };

if (true) {
    var varVariable = "I am var";               // "var" is function scoped!
    let letVariable = "I am let";
    const constVariable = "I am const";

    if (true) {
        var anotherVariable = "anotherVariable";
    }
}

console.log(varVariable);               
console.log(anotherVariable);               
// console.log(letVariable);                    // error
// console.log(constVariable);                  // error
