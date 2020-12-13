using System;
using System.Collections;
using System.Collections.Generic;

namespace _8.Polymorhism
{

    class Shape 
    {
    
    }
    class Rect : Shape
    {
       public string Name { get; set; }
    }

    interface IMovable    /// Interface !!!
    {
        void Move(int dx, int dy);
    }

    class MovableRect : Rect, IMovable
    {
        public void Move(int dx, int dy)
        {
            Console.WriteLine("Rect Moved");
        }
    }

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
    public class Program
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
            MoveObject(new MovableImage());
            MoveObject(new MovableRect());
            // MoveObject((IMovable)new Rect()); -> InvalidCastExcption ->  can not cast one type to another 



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
            
            Print( new List<int> { 1 , 2 , 3 , 4});
            Print( new int[] {1, 2, 3, 4 });
            Print( new string[] { "one", "two"});
           
        }

    }
}
