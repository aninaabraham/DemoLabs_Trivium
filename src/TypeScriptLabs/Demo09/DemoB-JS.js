console.info("------------ DEMO: Class Prototype (using JavaScript)");

function Person(name, age) {
    this.Name = name;
    this.Age = age;
}

Person.prototype.work = () => {
    console.log("Employee is working again!");
    console.log("Employee: " + this.Name + " is working again!");       // undefined
};

var p1 = new Person("Manoj", 25);
console.log("Name: " + p1.Name + " Age: " + p1.Age);
p1.work();
console.log('------------');
