namespace shapesActivity_demo 
{
    public  class Circle : Shapes
    {

        private double _radius;

        public Circle(string color, double radius) : base(color)
        {
            _radius = radius;
        }

        public override double GetArea()
        {
            return _radius * Math.PI;
        }




    }
}
