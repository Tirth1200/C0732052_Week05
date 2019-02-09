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
            elevator e = new elevator();
            e.run();
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
            Console.WriteLine("floor number is {0} ", FirstFloor.FloorNumber);

            SecondFloor = new Node();
            FirstFloor.elevatorUp = SecondFloor;
            SecondFloor.FloorNumber = "Second Floor";
            Console.WriteLine("floor number is {0} ", SecondFloor.FloorNumber);

            ThirdFloor = new Node();
            SecondFloor.elevatorUp = ThirdFloor;
            ThirdFloor.FloorNumber = "Third Floor";
            Console.WriteLine("floor number is {0} ", ThirdFloor.FloorNumber);

            FourthFloor = new Node();
            ThirdFloor.elevatorUp = FourthFloor;
            FourthFloor.FloorNumber = "Fourth Floor";
            Console.WriteLine("floor number is {0} ", FourthFloor.FloorNumber);
            FourthFloor.elevatorUp = null;
        }
    }
}
