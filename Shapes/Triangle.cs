using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{//pain inc
    public class Triangle
    {
        double edge;
        string color;
        public Triangle(double edge, string color)
        {
            this.edge = edge;
            if (color != null)
            {
                this.color = color;
            }
            else 
            {
                this.color = null;
            }

        }
        public double GetEdge()
        {
            return this.edge;
        }
        public string GetColor() 
        {
        return this.color;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public void SetEdge(double edge) 
        {
        this.edge = edge;
        }
        //Getters & Setters ^^^^^^^^^^^
        public static string Description()
        {
            return "Triangle has 3 edges that are equal to eachother and a color";
        }
        public override string ToString()
        {
            return $"triangle edge is: {this.edge} and color is: {this.color}";
        }
        public bool Equals(Triangle other)
        {
            if (this.edge == other.edge && this.color == other.color)
            {
                return true;
            }
            else return false;
        }       
        public double Area() 
        {
            double H =(Math.Sqrt(3) / 2)*this.edge;
            return this.edge/2 * H;
        }
        public double Parameter()
        {
            return this.edge*3;
        }
        public void IncEdgeByX(double X)
        {
            Console.WriteLine("Add X To Your Edges");
            Console.WriteLine("Set The Value Of X");
            this.edge += X;
            Console.WriteLine($"Edge is now equal to {this.edge}");
        }
        public void MultEdgeByX(double X)
        {
            Console.WriteLine("Mult X To Your Edges");
            Console.WriteLine("Set The Value Of X");
            this.edge *= X;
            Console.WriteLine($"Edge is now equal to {this.edge}");
        }
        public void IncEdge()
        {
            this.edge++;
            Console.WriteLine($"Edge Is now equal to {this.edge}");
        }
        public string Catagorize()
        {
            if (this.edge > 9000)
            {
                return "ITS OVER 9000!!!!!!!";
            }
            else if (this.edge < 5)
            {
                return "Very Small Boi";
            }
            else if (this.edge < 10)
            {
                return "Small Boi";
            }
            else if (this.edge <= 20)
            {
                return "Medium Boi";
            }
            else if (this.edge <= 30)
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
