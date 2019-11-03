using System;

namespace Class_Basics
{
    class MainClass
    {
        public static void Main(string[]  args)
        {
            ////First instance of Human
            //Human Noah = new Human();
            ////set first name of object 'Noah'
            //Noah.firstName = "Noah";
            //Noah.IntroduceMyself();

            ////Second instance of Human
            //Human Steven = new Human();

            ////set first name of object 'Steven'
            //Steven.firstName = "Steven";
            ////set last name of object 'Steven'
            //Steven.lastName = "Lopez";
            //Steven.IntroduceMyself();


            //Human basicHuman = new Human();
            //basicHuman.IntroduceMyself();

            Human Sam = new Human("Sam", "Grape");
            Sam.IntroduceMyself();

            Human Bilbo = new Human("Harry", "Potter", "Brown", 16);
            Bilbo.IntroduceMyself();

            Human Lars = new Human("Lars", "Smith", 37);
            Lars.IntroduceMyself();

            Human Kelly = new Human("Kelly", "Jordan", "Hazel");
            Kelly.IntroduceMyself();


        }
    }
}
