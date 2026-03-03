console.info("------------ DEMO: Check for TRUE");


let letVar = 10;
if (letVar) {
    console.log("letVar is truthy");
}

///*******
// * Uncomment the following lines to see the error message indicating all are always true!
 
    if ("hello") console.log("string is truthy");
    if (123) console.log("number is truthy");
    if ([]) console.log("empty array is truthy");
    if ({}) console.log("empty object is truthy");
    if ("true" == true) { }

//*/

if (true) console.log("THIS IS OKAY");
if ("hello" == "hello") console.log("THIS IS OKAY");
if ("hello" === "hello") console.log("THIS IS OKAY");
if (Boolean("true") == true) console.log("THIS IS OKAY");


