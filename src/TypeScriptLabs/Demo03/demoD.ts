console.info("------------ DEMO: Function Scope");

export { };

function test() {
    var insideFunction = "I am inside";         // var is function scoped in TYPESCRIPT
}

// console.log(insideFunction);            // error