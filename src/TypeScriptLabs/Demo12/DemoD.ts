export { };

console.info("------------ DEMO: Generic Interface");
console.info("------------       a Repository Pattern example");

interface Repository<T> {
    add(item: T): void;
    getAll(): T[];
}


class ProductsRepository implements Repository<string> {

    private items: string[] = [];

    add(item: string): void {
        this.items.push(item);
    }

    getAll(): string[] {
        return this.items;
    }

}

