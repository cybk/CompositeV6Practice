// See https://aka.ms/new-console-template for more information
using CompositeV6.BL;

Console.WriteLine("Hello, World!");

// First we create the initial tree estructure
DrawingElement root = new CompositeElement("Picture");
root.Add(new PrimitiveElement("Red Line"));
root.Add(new PrimitiveElement("Blue Circle"));
root.Add(new PrimitiveElement("Green Box"));

// We added a branch
DrawingElement com = new CompositeElement("Two Circles");
com.Add(new PrimitiveElement("Black Circle"));
com.Add(new PrimitiveElement("White Circle"));
root.Add(com);

// Now we add and remove an element
DrawingElement pe = new PrimitiveElement("Yellow Line");
root.Add(pe);
root.Remove(pe);

// Now, we call display names for display all the nodes recursively
root.Display(1);