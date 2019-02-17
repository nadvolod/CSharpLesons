using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Quiz
{
    [TestClass]
    public class QuizTicketTest
    {
        [TestMethod]
        public void Test_Lecture()
        {
            Lecture newLecture = new Lecture(2, "5", "5/20/2017", "Guest Speaker"
                , "Lecture", "New Hall", true, "Some info here", 12.99);
            Console.WriteLine(newLecture);
        }

        [TestMethod]
        public void Test_Musical()
        {
            Musical newMusical = new Musical(2, "5", "The Magic Flute", "Musical",
                "Theatre", "Mozart", "05/20/2017", true, true, false, 49.99);
            Console.WriteLine(newMusical);
        }

        [TestMethod]
        public void Test_Play()
        {
            Play newPlay = new Play(2, "5", "05/20/2017", "Death of a Salesman", "Play",
                "Theatre", true, 15, "Info here", 15.99);
            Console.WriteLine(newPlay);
        }
    }
}
