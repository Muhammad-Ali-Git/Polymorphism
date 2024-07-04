// See https://aka.ms/new-console-template for more information
using System;

public class Base
{
    public virtual void Print()
    {
        Console.WriteLine("Base Class Print");
    }
}

public class Derived : Base
{
    public override void Print()
    {
        Console.WriteLine("Derived Class Print");
    }
}

public class Program
{
    public static void Main ()
    {
        Base B = new Derived();
        B.Print();
    }
}

