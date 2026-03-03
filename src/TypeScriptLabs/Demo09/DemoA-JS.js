console.info("------------ DEMO: Class (using JavaScript)");

function Person(name, age) {

    this.Name = name;
    this.Age = age;

    let x = 10;     // non-exposed member of the function

    this.work = () => {
        console.log("Employee: " + this.Name + " is working!");
    };

}

var p1 = new Person("Manoj", 25);
console.log("Name: " + p1.Name + " Age: " + p1.Age);
p1.work();
console.log('--------');

console.log(typeof p1);             // Object
console.log(typeof Person);         // Function
console.log('--------');


Person.prototype.fire = () => {
    console.log(' employee has been fired!!');
};
p1.fire();
console.log('--------');

