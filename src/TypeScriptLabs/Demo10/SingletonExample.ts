export { }

console.info("------------ DEMO: Sealed Pattern");

class SealedClass {

    // Make the constructor private to prevent inheritance
    private constructor() {
        console.log("SealedClass instance created.");
    }


    public greet() {
        console.log("Hello!");
    }


    // A static method is needed to create instances of the class
    public static createInstance(): SealedClass {
        return new SealedClass();
    }

}

// Create an instance of the object
const instance = SealedClass.createInstance();
instance.greet();


/*********

class SubClass extends SealedClass { 

  constructor() {
    super();
  }

}

*****/