export { };

console.info("------------ DEMO: Polymorphism using Interface");
console.info("------------       Example of Dependency Inversion principle");


interface ILogger {
    log(message: string): void;
}


class ConsoleLogger implements ILogger {
    log(message: string) {
        console.log(message);
    }
}


class FileLogger implements ILogger {
    log(message: string) {
        console.log("Writing to file:", message);
    }
}


function doSomething(logger: ILogger) {
    logger.log("Processing started...");
}

doSomething(new ConsoleLogger());
console.log('------------------');

doSomething(new FileLogger());
console.log('------------------');
