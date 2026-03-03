export { }

console.info("------------ DEMO: Abstract Class");

/***
 * NOTE: You will need to compile this TypeScript file to its JS version, and run!
 *       NODE does not understand Advanced TypeScript syntax
 *       Eg: Abstract Class
 */

abstract class Shape {

    constructor(public color: string) { }

    abstract calculateArea(): number;

    showInfo(): string {
        return `This shape is in the color: ${this.color}`;
    }
}


class Circle extends Shape {

    constructor(color: string, public radius: number) {
        super(color);
    }

    calculateArea(): number {
        return Math.PI * this.radius * this.radius;
    }

    showInfo(): string {
        return `showInfo() called from Circle!  ${super.showInfo()}`;
    }
}


// const objShape = new Shape("red");           // Error

const objCircle = new Circle("blue", 5);

console.log("Area:", objCircle.calculateArea());
console.log(objCircle.showInfo());

