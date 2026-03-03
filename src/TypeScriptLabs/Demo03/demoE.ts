console.info("------------ DEMO: Hoisting");

export { };


var testVar;
console.log(testVar);           // undefined

// NOTE: If line #6 is commented, #7 shows "testVar" with ERROR
//       Because "use strict" is enforced (configured in the tsconfig.json file!) 
//      
//       The JavaScript parser would have declared the variable and added it to the DOM 
//       It would have hoisted it to the next above level!!

testVar = 100;
console.log(testVar);   // 100


let testLet;
console.log(testLet);   // undefined
testLet = 10;
console.log(testLet);   // 10
