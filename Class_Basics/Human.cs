using System;
namespace Class_Basics
{
    //Public class holding Human members
    public class Human
    {
        //member var
        private string firstName;

        //member var
        private string lastName;

        //member var
        private string eyeColor;

        //member var
        private int age;

        //default constructor
        public Human()
        {
            Console.WriteLine("Constructor called. Object created."); 
        }

        //parameterized constructor
        public Human(string firstName, string lastName, string eyeColor,int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        
        }

        public  Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }



        public void IntroduceMyself()
        {
            if (age != 0 && firstName != null && lastName != null && eyeColor != null)
                Console.WriteLine("Hi, I'm {0} {1}. I have {2} eyes. I am {3} years " +
                "old!", firstName, lastName, eyeColor, age);
            else if (age != 0 && firstName != null && lastName != null)
                Console.WriteLine("Hi, I'm {0} {1}. I am {2} years " +
                "old!", firstName, lastName, age);
            else if (firstName != null && lastName != null && eyeColor != null)
                Console.WriteLine("Hi, I'm {0} {1}. I have {2} eyes.", firstName, lastName, eyeColor);
            else if(firstName != null && lastName  != null)
                Console.WriteLine("Hi, I'm {0} {1}.", firstName, lastName);

        }
    }
}
