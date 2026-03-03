"use strict";
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
Object.defineProperty(exports, "__esModule", { value: true });
console.info("------------ DEMO: Inheritance");
/***
 * NOTE: You will need to compile this TypeScript file to its JS version, and run!
 *       NODE does not understand Advanced TypeScript syntax
 *       Eg: Inheritance
 */
var Person = /** @class */ (function () {
    function Person(name) {
        this.name = name;
    }
    Person.prototype.greet = function () {
        return "Hello, I am ".concat(this.name);
    };
    return Person;
}());
var Employee = /** @class */ (function (_super) {
    __extends(Employee, _super);
    function Employee(name, role) {
        var _this = _super.call(this, name) || this;
        _this.role = role;
        return _this;
    }
    Employee.prototype.describe = function () {
        return "".concat(this.name, " works as ").concat(this.role);
    };
    Employee.prototype.greet = function () {
        return "hello world";
    };
    return Employee;
}(Person));
var emp = new Employee("Manoj Kumar Sharma", "Architect");
console.log(emp.greet());
console.log(emp.describe());
var person = new Employee("Second Employee", "manager");
person.greet();
// person.describe();
