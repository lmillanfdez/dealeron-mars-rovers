**Dependencies**

In order to sucessfully execute this project, you will need to install the .NET Core 3.1 SDK on your machine.

**Setting up the project**

Run the following commands on the terminal in order to clone the project from GitHub, build and execute the project:
</br>
</br>
git clone https://github.com/lmillanfdez/dealeron-mars-rovers.git
</br>
cd DealerOnMarsRovers
</br>
dotnet build
</br>
.\DealerOnMarsRovers\bin\Debug\netcoreapp3.1\DealerOnMarsRovers.exe {input_file_absolute_path}

**Running the application**

When executing the application, you must pass in the absolute path of the file containing the input as a parameter to the executable file.

**Remarks about the implemented solution**

In implementing the solution a cycle linked list is used, whose nodes represent the four states (heading either north, east, south or west) a mars rover might be in at each position.
</br>
</br>
A linked list node has as a successor node the state the mars rover is gonna be in when it turns "right". The same way, each linked list node has as a predecessor node the state the mars rover is gonna be in when it is told to turn "left". Having this in mind, a linked list node is capable of processing "turns" commands, by returning the node corresponding to the resulting state. A linked list node is also gonna be responsible for processing "moves" commands, when possible (mars rover not going out of the plateau's bounds).