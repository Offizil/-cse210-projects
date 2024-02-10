using System;
using System.Drawing;


namespace shapesActivity_demo;


    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Learning05 World!");
            Console.WriteLine("We're practicing Polymorphism today");
            Console.WriteLine();
            List<Shapes> shapelist = new List<Shapes>();

            Square a_square = new Square(43, "green");
            shapelist.Add(a_square);

            Rectangle a_rect = new Rectangle("yellow", 32, 25);
            shapelist.Add(a_rect);

            Circle a_circ = new Circle("blue", 26);
            shapelist.Add(a_circ);

            foreach (Shapes s in shapelist)
            {
                string color = s.GetColor();
                double area = s.GetArea();

                Console.WriteLine($"The {color} shape has an area pf {area}");
            }

            

            


        }
    }




