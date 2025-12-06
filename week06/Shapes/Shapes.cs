using System;
using System.Formats.Asn1;
using System.Runtime.InteropServices;

class Shapes
{
    public virtual void FormulaForTheArea()
    {
        Console.WriteLine("The formula for the area of the shape is:");
    }
}

class Circle : Shapes
{
    public override void FormulaForTheArea()
    {
        Console.WriteLine("A=πr^2");
    }
}

class Triangle : Shapes
{
    public override void FormulaForTheArea()
    {
        Console.WriteLine("A=1/2bh");
    }
}

class Rectangle : Shapes
{
    public override void FormulaForTheArea()
    {
        Console.WriteLine("A=lxw");
    }
}