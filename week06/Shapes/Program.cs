using System;

class Program
{
    static void Main(string[] args)
    {
      Shapes basemsg = new Shapes();
      Shapes circle = new Circle();
      Shapes triangle = new Triangle();
      Shapes rectangle = new Rectangle();

      basemsg.FormulaForTheArea();
      Console.Write("Circle: "); circle.FormulaForTheArea();
      Console.Write("Triangle: "); triangle.FormulaForTheArea();
      Console.Write("Rectangle: "); rectangle.FormulaForTheArea();
    }
}