using Assignment;
//using Assignment.AbstractCommand;
using Assignment.InterfaceCommand;

namespace AssignmentTest
{
    [TestClass]
    public class AssignmentTests
    {

        //Unit Test for properties
        [TestMethod]
        public void RobotTesterProperty()

        {
            Robot robot = new();
            Assert.AreEqual(robot.NumCommands, 6);

            Assert.AreEqual(robot.IsPowered, false);
            robot.IsPowered = true;
            Assert.AreEqual(robot.IsPowered, true);

            Assert.AreEqual(robot.X, 0);
            robot.X = -5;
            Assert.AreEqual(robot.X, -5);

            Assert.AreEqual(robot.Y, 0);
            robot.Y = -5;
            Assert.AreEqual(robot.Y, -5);
        }

        // unit Test for OnOff Commands

        [TestMethod]

        public void OnOffTest()

        {
            Robot robot = new();
            robot.IsPowered = true;
            Assert.AreEqual(robot.IsPowered, true);

            robot.IsPowered = false;
            Assert.AreEqual(robot.IsPowered, false); ;

        }


        // Unit Test for South command
        [TestMethod]

        public void SouthTest()

        {
            Robot robot = new();
            robot.IsPowered = true;
            Assert.AreEqual(robot.Y, 0);
            robot.LoadCommand(new SouthCommand());
            robot.Run();
            robot.IsPowered = true;
            Assert.AreEqual(robot.Y, -1);
            robot.LoadCommand(new SouthCommand());
            robot.Run();

        }


        // Unit Test for North command
        [TestMethod]

        public void NorthTest()

        {
            Robot robot = new();
            robot.IsPowered = true;
            Assert.AreEqual(robot.Y, 0);
            robot.LoadCommand(new NorthCommand());
            robot.Run();
            robot.IsPowered = true;
            robot.IsPowered = false;
            Assert.AreEqual(robot.Y, 1);
            robot.LoadCommand(new NorthCommand());
            robot.Run();

        }

        // Unit Test for East command
        [TestMethod]

        public void EastTest()

        {
            Robot robot = new();
            robot.IsPowered = true;
            Assert.AreEqual(robot.X, 0);
            robot.LoadCommand(new EastCommand());
            robot.Run();
            robot.IsPowered = true;
            robot.IsPowered = false;
            Assert.AreEqual(robot.X, 1);
            robot.LoadCommand(new EastCommand());
            robot.Run();

        }

        // Unit Test for West command
        [TestMethod]

        public void WestTest()

        {
            Robot robot = new();
            robot.IsPowered = true;
            Assert.AreEqual(robot.X, 0);
            robot.LoadCommand(new WestCommand());
            robot.Run();
            robot.IsPowered = true;
            robot.IsPowered = false;
            Assert.AreEqual(robot.X, -1);
            robot.LoadCommand(new WestCommand());
            robot.Run();

        }




    }
}
