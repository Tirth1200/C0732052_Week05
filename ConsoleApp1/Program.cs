using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Node
    {
        public Node() { }
        public Node floor;
        public Node elevatorUp;
        public string FloorNumber;
    }
    class elevator
    {
        Node FirstFloor;
        Node SecondFloor;
        Node ThirdFloor;
        Node FourthFloor; 

        public void run()
        {
            FirstFloor = new Node();
            FirstFloor.FloorNumber = "First Floor";
            FirstFloor.elevatorUp = SecondFloor;
            SecondFloor.FloorNumber = "Second Floor";
            Console.WriteLine("floor number is {0} ", SecondFloor.FloorNumber);

        }
    }
}
