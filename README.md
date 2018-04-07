# AbstractFactoryExample

**Definition** 
Provide and interface for creating families of related or dependent objects without specifying their concrete classes

**Applicability**
This pattern is best used when:

- A system should be independent of how its products are created, composed and represented
- A system should be configured with one of multiple families of products
- A family of related product objects is designed to be used together, and you need to enforce this constraint
- You want to provide a class library of products, and you want to reveal just their interfaces, not their implementations

**Consequences**

- Isolates concrete classes
- It makes exchanging product families easy
- It promotes consistency among products
- Supporting new kinds of products is difficult