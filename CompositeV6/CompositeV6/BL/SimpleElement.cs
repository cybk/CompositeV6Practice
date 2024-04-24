namespace CompositeV6.BL
{
    public class SimpleElement : BaseElement
    {
        public SimpleElement(string name) : base(name)
        {
        }

        public override void Display(int indent)
        {
            Console.WriteLine($"{new string('-', indent)}+ {name}");
        }
    }
}