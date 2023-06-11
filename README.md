<p align="center">
	<a href="https://github.com/A00273725/IOT1026-Assignment-4/actions/workflows/ci.yml">
    <img src="https://github.com/A00273725/IOT1026-Assignment-4/actions/workflows/ci.yml/badge.svg"/>
    </a>
	<a href="https://github.com/A00273725/IOT1026-Assignment-4/actions/workflows/formatting.yml">
    <img src="https://github.com/A00273725/IOT1026-Assignment-4/actions/workflows/formatting.yml/badge.svg"/>
	<br/>
    <a href="https://codecov.io/gh/A00273725/IOT1026-Assignment-4" > 
    <img src="https://codecov.io/gh/A00273725/IOT1026-Assignment-4/branch/main/graph/badge.svg?token=JS0857X5JD"/> 
	<img title="MIT License" alt="license" src="https://img.shields.io/badge/license-MIT-informational?style=flat-square">	
    </a>
</p>

# IOT1026-Assignment-4
This is simple consle application for controlling robot. This is virtual robot.

The project includes the following components:

User Input: The RobotTester class prompts the user to enter command strings via the console. These command strings are converted into command objects and loaded into a Robot instance for execution.

Robot Control: The Robot class represents a virtual robot that can be controlled using commands. It maintains a list of loaded commands and executes them sequentially. The Robot's state, such as its position, is updated based on the executed commands.

Command Classes: The project includes command classes such as OnCommand, OffCommand, WestCommand, EastCommand, SouthCommand, NorthCommand, and CustomCommand. These classes implement the IRobotCommand interface and provide specific actions that can be performed on the Robot.

Unit Testing: The project includes unit tests to ensure the correct behavior of the Robot and the command classes. These tests cover various scenarios, including loading commands, executing commands, and verifying the final state of the Robot.

The project allows users to interactively control the Robot by entering command strings. The RobotTester class converts these strings into command objects, loads them into the Robot, and executes them. After each command execution, the Robot's state is displayed.


# Instruction for run

After running the program, you will see a console prompt that says "Enter command strings ( On, off, north, south, east, west). Enter 'Done' to finish."

To control the robot, you need to enter command strings as input. Each command represents an action that the robot will perform.

You can enter one command at a time. For example, you can enter "On" to turn on the robot or "North" to move the robot north.

The program will interpret your input and convert it into a command object. If the input is a valid command, it will be loaded into the robot for execution. If the input is not recognized as a valid command, the program will display an "Invalid command!" message.

You can continue entering command strings until you are finished giving instructions to the robot. To finish the program and see the final state of the robot, enter "Done" as the command string.

After each command execution, the program will display the current state of the robot. This may include information such as the robot's position or any other relevant details based on the specific implementation of the commands.

Once you enter "Done", the program will stop accepting input, and the final position of the robot will be displayed.

You can repeat the process by running the program again and entering new command strings to control the robot.

[Assignment Instructions](docs/instructions.md)  
[How to start coding](docs/how-to-use.md)  
[How to update status badges](docs/how-to-update-badges.md)
