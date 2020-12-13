using System;
using System.Collections;
using System.Collections.Generic;

namespace _8.Polymorhism
{

    abstract class Shape
    {
        public abstract double CalcArea();
    }
    class Rect : Shape
    {
        public int Width { get; private set; }
        public int Height { get; private set; }


        public Rect(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
        public override double CalcArea()
        {
            return this.Width * this.Height;
        }
    }
    // Interfaces implement kind of  multiple Inheritance, // child class can have many parents   
    class Circle : Shape  // one class can inherits only from one another class / a child class can have only one parent-- SingleInheritance
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double CalcArea()
        {
            return this.Radius * this.Radius * Math.PI;
        }

    }
    interface IMovable    /// Interface !!!
    {
        void Move(int dx, int dy);
    }

    //class MovableRect : Rect, IMovable
    //{
    //    public void Move(int dx, int dy)
    //    {
    //        Console.WriteLine("Rect Moved");
    //    }
    //}

    class Image
    {


    }
    class MovableImage : Image, IMovable   // MovalbeImage implements Method Move() from Interface IMovable
    {
        public void Move(int dx, int dy)
        {
            Console.WriteLine("Image moved");
        }
    }
    public class OopPrinciplesDemos
    {


        static void Print<T>(IEnumerable<T> items)
        {

            string line = new string('-', 30);  // we create an object of a type string
            Console.WriteLine(line);
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(line);
        }

        static void MoveObject(IMovable Obj)
        {
            Obj.Move(5, 1);
        }
        public static void Main()
        {

            Shape[] shapes =
            {

                new Rect(5, 6),
                new Circle(5)

            };

            foreach (Shape shape in shapes)            // We call the current object shape in the arrayShapes, we call it through 
            {                                         // the Abstract class Shape , the  abstract Shape Class has a method CalcArea
                Console.WriteLine(shape.CalcArea());
            }


            //IMovable[] movables = 
            //{
            //    new MovableRect(),
            //    new MovableImage()

            //};

            //foreach (var movable in movables) 
            //{
            //    movable.Move(5, 3);
            //}

            // List<int> numbers = new List<int> {1, 2, 3 , 4 };  
            // IEnumerable<int> numbers = new List<int> { 1, 2, 3, 4 }; // List inherits IEnumerable, 
            //thats why IEnumerable Object can keep a value of Oject List;
            // here is exampel of abstraction,  saying IEnumerable we say we will work with almost anithing that inherists from IEnumerable
            // List, Array , ......

            //Print( new List<int> { 1 , 2 , 3 , 4});
            //Print( new int[] {1, 2, 3, 4 });
            //Print( new string[] { "one", "two"});

            // Object of a type Parent  can keep , object values of a Type child .
            // oposite,  Object of type child can not keep values of Object of a type parent.


        }

    }
}
