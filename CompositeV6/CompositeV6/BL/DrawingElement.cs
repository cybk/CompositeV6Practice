namespace CompositeV6.BL
{
    public abstract class DrawingElement
    {
        protected string name = "";

        public DrawingElement(string name)
        {
            this.name = name;
        }

        public abstract void Add(DrawingElement e);

        public abstract void Remove(DrawingElement e);

        public abstract void Display(int indent);
    }
}