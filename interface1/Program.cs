
    public interface Drawable{
        void draw();
    }


public interface SetDrawable{
    void SetColour();


}

    public class Circle : Drawable, SetDrawable{
        public void draw(){
            Console.WriteLine("i can draw circle");
        }

        public void SetColour(){
            Console.WriteLine("i can do colour for circle");
        }
    }

    

    public class Square : Drawable{
        public void draw(){
            Console.WriteLine("I can draw Square");
        }
    }

    public class Traingle : Drawable{
        public void draw(){
            Console.WriteLine("i can draw Traingle");
        }
    }

    public class Rectangle : Drawable{
        public void draw(){
            Console.WriteLine("i can draw rectangle");
        }
    }

    public class Line : Drawable{
        public void draw(){
            Console.WriteLine("i can draw line");
            
        }
    }

namespace interface1{

        public class Program{


    public static void Main(string[] args){
        Drawable d;
        SetDrawable sd;
        
        d=new Circle();
        d.draw();
        sd=new Circle();
        sd.SetColour();

        d=new Square();
        d.draw();
        d=new Traingle();
        d.draw();
        d=new Rectangle();
        d.draw();
        Console.ReadLine();
        Line l=new Line();
        l.draw();
    }
    }
    }

