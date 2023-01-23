using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle
    {
        double radius;
        string color;
        public static string Description() 
        {
            return "Circle has a radius and color";
        }
        public Circle(double radius = 0.0, string color = "white")
        {
            this.radius = radius;
            this.color = color;
        }
        public Circle(string color)
        {
            this.radius = 0.0;
            this.color = color;
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle()
        {
                
        }
        //Getters & Setters\\
        public double GetRadius()
        {
            return this.radius;
        }
        public bool SetRadius(double radius)
        {
            if(radius < 0.0) {
                return false;
            }
            this.radius = radius;
            return true;
        }
        public string GetColor()
        {
            return this.color;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        //*Getters&Setters*\\
        public bool Eqauls(Circle other)
        {

            if (this.radius == other.radius && this.color == other.color)
            {
                return true;
            }
            else return false;
        }
        public override string ToString()
        {
            //string v=($"My circle radius is: {this.radius} and color is: {this.color}");
            //return v.ToString();
            return $"My circle radius is: {this.radius} and color is: {this.color}";
        }
        public double Area()
        {
            return (Math.PI * Math.Pow(this.radius,2));
        }
        public double Peramiter()
        {
            return 2 * Math.PI * this.radius;
        }
        public void IncreeseRadius()
        {
            this.radius++;
        }
        public void IncRadBySize(double size)
        {
            Console.WriteLine("Enter a size to increese your radius by that size");
            size = double.Parse(Console.ReadLine());
            this.radius += size;
        }
        public void MultRadBySize(double size)
        {
            Console.WriteLine("Enter a size to multiply your radius by that size");
            size = double.Parse(Console.ReadLine());
            this.radius *= size;
        }
        public string Catagorize()
        {
            if (this.radius > 9000)
            {
                return "ITS OVER 9000!!!!!!!";
            }
            else if (this.radius < 5)
            {
                return "Very Small Boi";
            }
            else if (this.radius < 10)
            {
                return "Small Boi";
            }
            else if (this.radius <= 20)
            {
                return "Medium Boi";
            }
            else if (this.radius <= 30)
            {
                return "Meduim Fine";
            }
            else
            {
                return "Big Boi";
            }
        }
        
    }
}