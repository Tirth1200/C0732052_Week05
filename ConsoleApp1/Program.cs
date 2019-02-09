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
            BubbleWSort bs = new BubbleWSort();

            bs.run();

            Console.ReadLine();
        }
    }
    class Node
    {
        public Node() { }
        public Node floor;
        public Node elevatorUp;
        public string FloorNumber;
    }

    class Department
    {
        public Department(string dept_name)

        {

            DepartmentDescription = dept_name;

        }
        public Department nextDepartment;
        public Department aDepartment;
        string DepartmentDescription;
    }
    class DepartmentStore
    {
        public void InitializeDepartments()
        {
            Department Kitchenware = new Department("Kitchenware");
            Department Books = new Department("Books");
            Kitchenware.nextDepartment = Books;
            //Kitchenware.previousDepartment = FirstFloor;
            
        }
    }
    class elevator { 
    
        Node Head;
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

        public void traverseList()
        {
            Node temp;
            temp = Head.elevatorUp;
            // Where am I going to Start?
            Console.WriteLine("The first floor is " + Head.FloorNumber);
            while (temp != null)
            {
                // NOW GET TO THE SECOND FLOOR!!!
                temp = temp.elevatorUp;
                Console.WriteLine(temp.FloorNumber);
            }
        }
    }
    class BubbleWSort
    {

        public void run()

        {

            int[] ar = new int[5] { 4, 5, 6, 2, 3 };

            int mid = 0, temp = 0;



            for (int i = 0; i < ar.Length; i++)

            {



                for (int j = 0; j < ar.Length - 1; j++)

                {

                    temp = 0;

                    if (ar[j] > ar[j + 1])

                    {

                        temp = ar[j + 1];

                        ar[j + 1] = ar[j];

                        ar[j] = temp;

                    }

                }



            }

            for (int i = 0; i < ar.Length; i++)

            {

                Console.Write("{0} ", ar[i]);

            }
        }
}
