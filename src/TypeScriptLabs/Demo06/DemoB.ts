export { };

console.info("------------ DEMO: Return type - Type Inference (Important!)");

// NOTE: Return type is inferred.  
//       Generally not recommended!
function greet(name: string){
    // return `Hello, ${name}`;
    return 10;
}

let message = greet("Manoj");               // ( Check intellisense in VS hover on greet() )
console.log(message);

message = 10;
