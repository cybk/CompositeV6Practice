﻿namespace CompositeV6.BL
{
    public class CompositeElement : BaseElement, ICompound
    {
        private readonly IList<BaseElement> elements = new List<BaseElement>();

        public CompositeElement(string name) : base(name)
        {
        }

        public void Add(BaseElement e)
        {
            elements.Add(e);
        }

        public void Remove(BaseElement e)
        {
            elements.Remove(e);
        }

        public override void Display(int indent)
        {
            // Display the level and name for the element
            Console.WriteLine($"{new string('-', indent)}+ {name}");

            // Display each child element on this node
            elements.ToList().ForEach(el => el.Display(indent + 2));
        }
    }
}