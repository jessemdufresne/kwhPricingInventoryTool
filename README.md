# kwhPricingInventoryTool
Lacking a central inventory management application can pose significant challenges for any volunteer-run organization, such as  redundant purchasing, inventory management errors, and internal miscommunication. This web application, built on the .NET Framework with C#, helps volunteer-run organizations (like KiloWatts for Humanity) manage their data logger inventory across implementation projects. The web app establishes an organization-wide inventory management system that centralizes the information. As a result, decision-making and information transfer among incoming and outgoing volunteers during the planning stages of future installations will be greatly improved. 

# Requirements
### [Visual Studio 2019 Community](https://visualstudio.microsoft.com/downloads/)

Windows (Version 16.5) or For Mac (Version 8.5.3)

### .NET Core SDK 3.1.2
To check version… 

**Windows (Version 16.5)**
1.	Open Visual Studio.
2.	Select **Help** > **About Microsoft Visual Studio**.
3.	Read the version number from the **About** dialog.

**For Mac (Version 8.5.3)**
1.	Open Visual Studio.
2.	Select **Visual Studio** > **About Visual Studio**.
3.	Read the version number from the **Show Details** button.

### MySql (Version 8.0.19)
https://bertvv.github.io/notes-to-self/2015/11/16/automating-mysql_secure_installation/

https://gist.github.com/Mins/4602864#gistcomment-1294952

---

If when you try `mysql -u root -p` and you cannot connect to MySQL… 

You must start the server

Enter `mysql.server status` to confirm server status

Enter `mysql.server start`

Then try `mysql -u root -p`  again 

---

### Downloading MySQL on macOS

**Mysql 8.0.19 requires macOS >= 10.10** | https://flaviocopes.com/mysql-how-to-install/

Using Homebrew (a software package manager on Mac OS) to download MySQL

`/usr/bin/ruby -e "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install)"`

`brew install mysql`

`mysql server start`

Configure root password
```
mysql_secure_installation
ENTER
Y
2
uRootPass1!
uRootPass1!
Y
Y
Y
```
```
mysql -u root -p
mysql> create database das;
mysql> exit;
```
Build kwh.csproj in Visual Studio

`mysql.server {start|status|stop}`

---

### [Downloading MySQL on Ubuntu](https://www.digitalocean.com/community/tutorials/how-to-install-mysql-on-ubuntu-18-04)

MySQL on Ubuntu 18.01
```
sudo apt update
sudo apt install mysql-server
sudo mysql_secure_installation
```

---

### Downloading MySQL on Windows
* Access download [here](https://dev.mysql.com/downloads/file/?id=495321)
* Click **No thanks, just start my download**
* Double click to run the MySQL installer. 
* License Agreement > **Accept**
* Setup Type > **Server only**
* If there are path conflicts… Change Data Directory from “C:\Program\MySQL\MySQL Server **8.0**” to “C:\Program\MySQL\MySQL Server **8**”
* Check requirements and install any other required software (e.g. Visual Studio)
* Installation > **Execute**
* Continue with installer…
* Group Replication > **Standalone MySQL Server**. This should be the default option.
* Continue with installer…
* Authentication Method > Select “Use Strong Password Encryption”
..* Choose your MySQL Root Password
* Continue with installer…
* **Execute** to apply configurations
* **Finish**
*	Connect to Server > Enter User: **roo**t and Password: **yourPasswordHere** > **Check**
*	**Execute** to apply further configurations
*	**Finish**

Now in command line…

Type `mysql -u root -p`

Enter password

`mysql> create database das;`

`mysql> exit;`

---

After installing MySQL and Visual Studio, you can now build the project. 

Open the project in Visual Studio

Navigate to **Properties** > **launchSettings.json**

Confirm that http://localhost:5000 is correct. You may change the port.

Click the **Build** button in the top left

