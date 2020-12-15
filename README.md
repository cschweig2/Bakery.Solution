# Bakery

#### Independent Code Review, Last Updated 12.11.2020

#### **By Chelsea Becker**

## Description

_Bakery is a program that allows the user to view the cost of pastries and bread sold at the bakery, place an order, and then view their total cost for the order. There are deals available for the customer, such as "buy 2 for $8" for bread, and "buy 2 for $3" for pastries._

## Setup/Installation Requirements

### Installing .NET Framework for Windows(10+) Users

1. _Download the 64-bit .NET Core SDK (Software Development Kit) by following this link: https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer._<br>
1a. _Follow prompts to begin your download. The download will be a .exe file. Click to install when it is finished downloading._
2. _After clicking the downloaded .exe file, follow the prompts in the installer and use suggested default settings._
3. _You can confirm a successful installation by opening a command line terminal and running the command $ dotnet --version, which should return a version number._


### Installing .NET Framework for Mac Users

1. _Download the .NET Core SDK by following this link: https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer._<br>
1a. _Follow prompts to begin your download. The download will be a .pkg file. Click to install when it is finished downloading._
2. _After clicking the downloaded .pkg file, follow the prompts in the installer and use suggested default settings._
3. _You can confirm a successful installation by opening a command line terminal and running the command $ dotnet --version, which should return a version number._


### View locally

1. _Open web browser and go to https://github.com/cschweig2/Bakery.Solution._
2. _After clicking the green "code" button, you can copy the URL for the repository._
3. _Open a terminal window, such as Command Prompt or Git Bash._<br>
  3a. _Type in this command: "git clone", followed by the URL you just copied. The full command should look like this: "git clone https://github.com/cschweig2/Bakery.Solution"._
4. _View the code on your favorite text editor, such as Visual Studio Code._
5._To run the program, you will need to first navigate to the Bakery and Bakery.Tests folders and enter "dotnet restore" in the command line to install packages._
6._After packages are installed in each of these folders, you may use "dotnet run" to both run and build the program._

## Known Bugs

No known bugs at this time.

## Test Specs

<table>
  <tr>
    <th>Test #</th>
    <th>Expected Behavior</th>
    <th>Input</th>
    <th>Output</th>
  </tr>
  <tr>
    <td>1</td>
    <td>Create a Bread class</td>
    <td>Bread bread = new Bread();</td>
    <td>bread</td>
  </tr>
  <tr>
    <td>2</td>
    <td>Method returns price of 1 order of bread</td>
    <td>bread.GetPrice()</td>
    <td>5</td>
  </tr>
  <tr>
    <td>3</td>
    <td>Method sets price of 1 order of bread</td>
    <td>bread.SetPrice()</td>
    <td>2</td>
  </tr>
  <tr>
    <td>4</td>
    <td>Create a Pastry class</td>
    <td>Pastry pastry = new Pastry();</td>
    <td>pastry</td>
  </tr>
  <tr>
    <td>5</td>
    <td>Method returns price of 1 order of a pastry</td>
    <td>pastry.GetPrice()</td>
    <td>2</td>
  </tr>
  <tr>
    <td>6</td>
    <td>Method sets price of 1 order of a pastry</td>
    <td>pastry.SetPrice()</td>
    <td>1.5</td>
  </tr>
  <tr>
    <td>7</td>
    <td>Create a Drink class</td>
    <td>Drink coffee = new Drink();</td>
    <td>coffee</td>
  </tr>
  <tr>
    <td>8</td>
    <td>Method gets price of a coffee</td>
    <td>coffee.GetPrice();</td>
    <td>2</td>
  </tr>
</table>
<br>


## Support and contact details

_If you run into any issues, you can contact the creator at chelraebecker@gmail.com, or make contributions to the code on GitHub via forking and creating a new branch._

## Technologies Used

_VS Code_ <br>
_C# version 7.3_<br>
_.NET Core version 2.2_<br>
_REPL_<br>

## Legal

*This software is licensed under the MIT license.*

Copyright (c) 2020 **Chelsea Becker**