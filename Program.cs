using System;
using System.Collections;
using System.Collections.Generic;

namespace _8.Polymorhism
{
    interface IMovable    /// Interface !!!
    {
        void Move(int dx, int dy);
    }
    interface IDrawable
    {
        void Draw();
    }

    abstract class Shape : IDrawable
    {
        public abstract double CalcArea();  //abstract method has no body, it must be implemeted, developed into the child classes


        public virtual string Name
        {
            get
            {
                return "Shape";
            }
        }
        public Shape()
        {

        }
        public override string ToString()
        {
            return string.Format("This is a shape !{0} ", this.Name);
        }

        public virtual void Draw()   // this method comes from an interface and also can be made vitual in a class 
        {
            Console.WriteLine("Shape is drawn");
        }
    }
    class Rect : Shape
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public override string Name
        {
            get
            {
                return "Rect";
            }
        }

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

    class Square : Rect
    {
        public Square(int side) : base(side, side)
        {

        }
        public override double CalcArea()
        {
            Console.WriteLine("In Square");
            return base.CalcArea();
        }
        public override string Name
        {
            get
            {
                return "Square";
            }
        }
    }

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

            object rect = new Square(5);
            Console.WriteLine(((Shape)rect));
            Console.WriteLine(((Rect)rect));
            Console.WriteLine(new Rect(5, 6));

            //Console.WriteLine(new Rect(5, 1).ToString());



            //Shape[] shapes =
            //{

            //    new Rect(5, 6),
            //    new Circle(5)

            //};
            //foreach (var s in shapes)
            //{
            //    Console.WriteLine(s.Name);
            //}

            //foreach (Shape shape in shapes)            // We call the current object shape in the arrayShapes, we call it through 
            //{                                         // the Abstract class Shape , the  abstract Shape Class has a method CalcArea
            //    Console.WriteLine(shape.CalcArea());
            //}


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
            // the abstract class i like any other class , but has a bastract methods and can  not have a intatiation, can not make of it objects, 
            // abstract class is made to be implemented, to be iherited !
            // when there is an abstract method then the class shoud be only abstract, abstract methods should be implemented into the child classes
            // when we have virtual method, our class is not compulsary to be astract class 
            //the method is marked as virtual then it can be overriden, replaces, implemented into the child classes
            // abstract methods are purely virtual, if amethod is an abstract it is virtual 
            // interface members are purely virtual -they have no implementation and are made to be overriden in a descendant classes
            // virtual methods can be hidden through the new keyword "new "
            // Polymorhism --is : assigning a value of an Object of parent type to a value of child type.
            //  Of an object of type parent we give a value of type child-inheritor 
            //Cohesion --to serve to one purpose- to be strong independant !
            // Cohesion -every method or class , to do a certain thing and to do it independantly to do it perfectly, to serve one aim, one thing !
            // strong cohesion class is an example of good, strong cohersion !!
            // Coupling --must be weak -> connecton of components, dependancy of the components !
            // example for good coupling is the HDD -we remove the cable, we put new HHD and it works
            //Example for bad coupling , strong  coupling --the VideoCard to the  MotherBoard--it is hard to remove it!
            // interface is kind a empty class who says what will be doing into our child classes;


        }

    }
}
