using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section8
{
    [TestClass]
    public class SwitchStatements
    {
        [TestMethod]
        public void Test_Switch_Statements()
        {
            int weekDay = 4;
            string testDay = "";

            switch (weekDay)
            {
                case 1:
                    testDay = "Monday";
                    break;
                case 2:
                    testDay = "Tuesday";
                    break;
                case 3:
                    testDay = "Wednesday";
                    break;
                case 4:
                    testDay = "Thursday";
                    break;
                case 5:
                    testDay = "Friday";
                    break;
                default:
                    testDay = "Not Monday through Friday";
                    break;
            }

            StringAssert.Equals(testDay, "Thursday");

        }

        [TestMethod]
        public void Switch_State_Names()
        {
            string stateAbbrev = "GA";
            string stateName = "";

            switch (stateAbbrev)
            {
                case "AL":
                    stateName = "Alabama";
                    break;
                case "FL":
                    stateName = "Florida";
                    break;
                case "GA":
                    stateName = "Georgia";
                    break;
                case "IL":
                    stateName = "Illinois";
                    break;
                case "KY":
                    stateName = "Kentucky";
                    break;
                case "MI":
                    stateName = "Michigan";
                    break;
                default:
                    stateName = "No Match";
                    break;
            }

            StringAssert.Equals(stateName, "Georgia");
        }
    }
}
