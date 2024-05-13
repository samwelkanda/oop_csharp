using System.Diagnostics.Contracts;
using System.Net.NetworkInformation;

namespace Basic;

/* Represents a point in 2-D space */ 
class Point(float x = 0, float y = 0) {
    public float X { get; set; } = x;
    public float Y { get; set; } = y;
}


class Rectangle(float width, float height, Point corner)
{
    public float Width {get; } = width;

    public float Height {get; } = height;

    public Point Corner {get; } = corner;


    public float GetArea()
    {
        return this.Width * this.Height;

    }

    public float GetPerimeter()
    {
        return 2 * (this.Width + this.Height);
    }

    public override string ToString()
    {
        return $"Width: {this.Width}, Height: {this.Height}, Corner: ({this.Corner.X}, {this.Corner.Y})";
    }

}


class Species(string Name)
{
    public string Name {get;} = string.IsNullOrEmpty(Name) ? throw new ArgumentException("Name cannot be empty") : Name;

    public static Species FromFullName(string fullName)
    {
        return new Species(fullName.Split()[0]);
    }

    public override string ToString()
    {
        return this.Name;
    }

}

