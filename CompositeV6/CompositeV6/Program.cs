// See https://aka.ms/new-console-template for more information
using CompositeV6.BL;

Console.WriteLine("Hello, World!");

// First we create the initial tree estructure
BaseElement root = new CompositeElement("Picture");
root.Add(new SimpleElement("Red Line"));
root.Add(new SimpleElement("Blue Circle"));
root.Add(new SimpleElement("Green Box"));

// We added a branch
BaseElement com = new CompositeElement("Two Circles");
com.Add(new SimpleElement("Black Circle"));
com.Add(new SimpleElement("White Circle"));
root.Add(com);

// Now we add and remove an element
BaseElement pe = new SimpleElement("Yellow Line");
root.Add(pe);
root.Remove(pe);

// Now, we call display names for display all the nodes recursively
root.Display(1);