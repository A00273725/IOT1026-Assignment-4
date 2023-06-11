// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.InterfaceCommand;

namespace Assignment
{
    internal class RobotTester
    {
        public void TestRobot()
        {
            Robot robot = new Robot();




            Console.WriteLine("Enter command strings \nOn \noff \nnorth \nsouth \nwest \neast \nEnter 'Done' to finish.");

            string input;
            do
            {
                input = Console.ReadLine();

                if (input != "Done")
                {
                    IRobotCommand command = CreateCommand(input);

                    if (command != null)
                    {
                        robot.LoadCommand(command);
                    }
                    else
                    {
                        Console.WriteLine("Invalid command!");
                    }
                }

            } while (input != "Done");

            Console.WriteLine("\nExecuting robot commands...\n");

            robot.Run();

            Console.WriteLine($"Final position: ({robot.X}, {robot.Y})");
        }

        private static IRobotCommand CreateCommand(string input)
        {
            switch (input.ToLower())
            {
                case "on":
                    return new OnCommand();
                case "off":
                    return new OffCommand();
                case "west":
                    return new WestCommand();
                case "east":
                    return new EastCommand();
                case "south":
                    return new SouthCommand();
                case "north":
                    return new NorthCommand();
                default:
                    return null;
            }
        }
    }
}
