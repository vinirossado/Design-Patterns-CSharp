using Visitor;

IElement element1 = new ConcreteElement1();
IElement element2 = new ConcreteElement2();

IVisitor visitor1 = new ConcreteVisitor1();
IVisitor visitor2 = new ConcreteVisitor2();

element1.Accept(visitor1);
element2.Accept(visitor1);

element1.Accept(visitor2);
element2.Accept(visitor2);