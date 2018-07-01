using System;

namespace Section6
{
    class Car
    {
        //private variables that help us define properties
        //of a car (or the class)
        string color;
        int numberOfDoors;
        int speed;
        //bool isConvertable;

        //Constructor - factory for creating objects of the class
        public Car(string carColor, int doors, bool convertable)
        {
            Color = carColor;
            NumberOfDoors = doors;
            IsConvertable = convertable;
        }

        //Get and Set Accessors - Properties that define noun-like 
        //attributes of the class
        public string Color
        {
            get
            {return color; }
            set
            {color = value;}
        }

        public bool IsConvertable
        {
            get; set;
        }

        public int NumberOfDoors
        {
            get { return numberOfDoors; }
            set
            {
                if(value <= 4)
                {
                    numberOfDoors = value;
                }
                else
                {
                   //give the user some kind of appropriate error
                }
            }
        }

        //Methods - Verb attributes that tell what a class can do
        public void Accelerate()
        {
            int speed = 0;
            Console.WriteLine("I am accelerating to " + speed + " miles per hour");
        }

        public bool FamilyCar()
        {
            if(NumberOfDoors >= 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
