# _Pete's Treats_ 

#### By _**Ryan Ashby**_ 

#### _This application allows a user to add a series of "treats" to a database table. The application also allows the user to add a series of "flavors" to a separate table in the database. Treats and flavors are tied together in a separate join table, using a many-to-many relationship structure._

### _Link to GitHub Repository_

* https://github.com/rjashby/PetesTreats.Solution

## Technologies Used 

* _VS Code Software_
* _Git_
* _Github_
* _C#_
* _.NET5_
* _ASP.NET Core_
* _MVC_
* _Razor View Engine_
* _MySQL Workbench_
* _Windows PowerShell_
* _Identity_

## Description 

_This simple C# application gathers input from a user from form input fields. The user can add "flavor" objects to a list of flavors, which are stored in a database table._

_Users will also be able to "treat" objects to a list treats, stored in a separate database table._

_Both flavors and treats will be displayed in a list on the relevant pages. The flavor and treat tables are connected via a third join table, titled "TreatFlavor."_

_The entirety of the application will be subject to login authorization via Identity. Read functionality is universal. A registered user can creat, edit, or delete flavors and treats as necessary, automatically updating the database._
 
## Setup/Installation Requirements 

**Required Software**

1) _You will need some type of coding software should you wish to view and edit the code. VS Code is an example of a free code editor, which can be downloaded at [VS Code](https://code.visualstudio.com/)_.

2) _Additionally, you will need to download the .NET framework, which can be downloaded at [.NET5](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)_.

3) _To effectively work with the database, download MySQL Workbench at [MySQL Workbench](https://dev.mysql.com/downloads/workbench/)._


**Cloning**

1) _In order to utilize this page on your local machine, you will need to clone a copy of this repository._

2) _Navigate to your desired directory in your command terminal and run:_ ``` $ git clone https://github.com/rjashby/PetesTreats.Solution```

3) _Once cloned, open the folder of the cloned repository in your code editor to view all the necessary files._


**Downloading**

1) _In your browser, navigate to https://github.com/rjashby/PetesTreats.Solution, and click the green "Code" button, which will provide a drop down menu. Click on "Download ZIP" at the bottom of the menu, and save it to your desired location._

2) _Once downloaded, unzip and extract the files._

3) _Follow the steps above to view, edit, and open the files as needed._


**Running the Program**

1) _In your terminal, navigate to the PetesTreats folder by starting at the root directory and typing the following into your terminal:_ ```cd PetesTreats```

2) _In the PetesTreats directory run ```dotnet restore``` to download the needed dependencies._

3) _Once here, you will need to run the following in your terminal:_ ```dotnet build```

4) _Once the project builds (and no errors appear), you can run the program by entering the following in your terminal:_ ```dotnet run```

5) _If you wish to changes made in real time, you may run:_ ```dotnet watch run```

6) _At this stage, only the basic layout will be in place. You will first need to build the database to effectively use the application._


**Initial Database Setup** 

1) _Start by creating an appsettings.json file in the main/root directory. This file should BE KEPT PRIVATE and should be populated with the following lines of code:_

```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[Your Database Name Goes Here];uid=[Your Id Goes Here];pwd=[Your Password Here];"
  }
}
```
2) _Ensure that your .gitignore file includes the following files before pushing to GitHub:_

``` 
*/obj/
*/bin/
.vscode
*/appsettings.json
```

**Creating The Database**

1) _Ensure that you have proper tools installed. Start by installing dotnet ef by running the following command in your terminal:_```dotnet tool install --global dotnet-ef```

2) _You can now add your initial migration. This will add a "Migrations" directory to your "PetesTreats" directory. Navigate to your "PetesTreats" directory and run the following command in your terminal:_ ```dotnet ef migrations add Initial```

3) _You will now have an "Initial" migration with which you can build and view the database. Now run the following command in your terminal in the "PetesTreats" directory:_ ```dotnet ef database update```

4) _If you want to view the database, open MySQL Workbench. You should see your database, with the appropriate tables and columns. Note: the database name will be based on the name you supplied. See: Initial Database Setup, Step 1._

## Known Bugs 

* _No Known Bugs._  

### License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT). Copyright (C) 2022 Ryan Ashby. All Rights Reserved.

```
MIT License

Copyright (c) 2022 Ryan Ashby.

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and 
associated documentation files (the "Software"), to deal in the Software without restriction, including 
without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so 
subject to the following conditions:

The above copyright notice and this permission notice shall be included 
in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE 
AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY 
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, 
ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
```

------------------------------

<a href="#">Return to Top</a>