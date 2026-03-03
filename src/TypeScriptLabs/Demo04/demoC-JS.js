console.info("------------ DEMO: Check for `null` or `undefined`");


// TRY: assigning NULL to this variable
let testLet;                     // declared but not assigned. So it is "undefined"

console.log("testLet: " + testLet);

console.log("testLet Type:" + typeof testLet);

if (testLet == null) {
    console.log("testLet == null => true");
} else {
    console.log("testLet == null => false");
}

if (testLet == undefined) {
    console.log("testLet == undefined => true - loose equality");
} else {
    console.log("testLet == undefined => false");
}


if (testLet === null) {
    console.log("testLet === null => true");
} else {
    console.log("testLet === null => false");
}

if (testLet === undefined) {
    console.log("testLet === undefined => true");
} else {
    console.log("testLet === undefined => false");
}
