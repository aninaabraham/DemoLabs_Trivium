# TypeScript Demos

## to install nodejs

(https://nodejs.org/en/download)

### to check node version

	```
	> node --version
	```

---

## to install Typescript

```
> npm install --global typescript

```

### To check if TypeScript is installed 

	```
	> tsc --version
	```
---

## To setup the folder

1. Create a folder for the demos, and configure it.
	```
	> tsc --init
	```

	This creates a `tsconfig.json` file

2. Let's setup a simple and clean configuration

	```
	{
	  "compilerOptions": {
		"target": "ES2020",
		"module": "ES2020",
		"rootDir": "./",
		"outDir": "./dist",
		"strict": true,
		"esModuleInterop": true
	  },
	  "include": ["**/*.ts"]
	}
	```

### Why Simplify?

Configurations like:

	"module": "nodenext"

	This mode:
	- Tries to intelligently switch between CommonJS and ESM
	- Depends on your package.json
	- Changes behavior based on file extensions
	Not something you want to learn about right now.

	-----------------------------------------------

	"verbatimModuleSyntax": true

	This:
	- enforces extremely strict module behavior.
	- Great for production environments.
	Not necessary for learning basics.

	-----------------------------------------------

	"moduleDetection": "force"

	This forces every file to be treated as a module.
	Again — advanced behavior.

---

## To Compile a TypeScript File

	> tsc <filename>

---

### To Run

	> node <filename>

---

## Demo 01: First example

1. Create a file `Demo01.ts`

2. To transpile the TypeScript file to JavaScript:
	```
	> tsc demo01
	```
	This generates the `Demo01.js` file.

3. To Run the example (using the transpiled JavaScript file):
	```
	node demo01.js
	```
   To run the example without transpiling it to JavaScript:
	```
	node demo01.ts
	```

## Demo 02: `export` and `import`

1. Create `person.ts`
2. Create `demo02.ts`
3. To Run the sample:
	```
	> tsc demo02
	> tsc person
	> node demo02.js
	```

## Demo 03: `var` vs `let` vs `const`

Introduces to:
- Scope differences
- Re-declaration rules
- Re-assignment rules
- Hoisting behavior
- Best practice usage

| Feature     | var | let  | const |
| ----------- | --- | ---- | ----- |
| Reassign    | YES | YES  | NO    |
| Redeclare   | YES | NO   | NO    |
| Block Scope | NO  | YES  | YES   |
| Hoisted     | YES	| Yes* | Yes*  |
| Recommended | NO | YES  | YES   |

	Yes* Temporal Dead Zone (TDZ)
	(https://www.geeksforgeeks.org/javascript/temporal-dead-zone-in-javascript/)

Best practices:
- use `const` by default.
- Use `let` when value changes.
- Avoid using `var` - preferably never!


## Demo 04: `null` vs `undefined`

- Undeclared variables
- Using the Strict Equality Operator `===` vs `==`
- Using the `typeof` Operator providing type safety
- Check for `null` or `undefined`
- Nullish Coalescing Operator `??`


## Demo 05: Understanding `true` vs `false`

There are ONLY a few falsy values in JavaScript:

	```
	false
	0
	-0
	0n
	""
	null
	undefined
	NaN
	```

Everything else is truthy.

Demonstrates:
- null
- undefined
- ??
- typeof

---

Demo 06: Functions

- Parameter typing
- Return type
- Optional parameters
- Default parameters
- Type inference
- JSDoc style documentation
- Arrow Functions

---

Demo 07: Function Overloads

- Overloads
- Union types
- Type narrowing
- Runtime safety
- Arrow Functions

---

Demo 08: Union Types and Type Narrowing

- What is a Union Type?
- Why TypeScript restricts access
- How Type Narrowing works
- typeof narrowing
- instanceof narrowing

- Object Vs Primitive

---

Demo 09: Class

- Class
- Constructor
- Methods
- Readonly members
- Parameter Properties
- Inheritance
- Access Modifiers - public, private, protected
- Getters and Setters
- Static members
- Abstract Classes

---

Demo 10: Example

---

Demo 11: Interface

Characteristics of an Interface in TypeScript
- No constructor
- No implementation
- No access modifiers
- No runtime presence
- A class can implement any number of interfaces

Characteristics of an Abstract Class in TypeScript
- Can have constructor
- Can have concrete methods or abstract methods
- Can have access modifiers
- Exists at runtime
- A class can extend only one super class

---

Demo 12: Generics

---
