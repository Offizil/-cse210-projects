


namespace shapesActivity_demo 
{
    public  class Square : Shapes
    {

        private double _side = 0;


        public Square(double side, string color ) : base(color)
        {
            _side = side;
        }

        public override double GetArea()
        {
            return  _side * _side;
        }




    }
}
