namespace Inheritance;

public interface I2DShape
{
    
}

public class Rectangle : I2DShape
{

    double length;

    double breadth;

     public Rectangle(double l ,double b)
     {
         length = l;
         breadth = b;
     }

    public double GetArea() => length * breadth;

    public double GetPerimeter() => 2 *(length + breadth);
    public double getDiagonal( ) => MathPI*2*radius;

}

public class Square :Rectangle
{
    public Square(double side) : base(side,side)
    {

    }


}

//for Triangle
 
 public class circle : I2DShape
 {
     double radius;

     public circle(double r)
     {
         radius = r;

     }
      public double GetArea() =>Math.PI * radius * radius;
      public double GetPerimeter() => Math.PI * radius;


      }
 