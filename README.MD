# RM2k2XP

RM2k2XP can be used to convert old RPG Maker 2000/2003 styled charset and chipset to XP format.

RM2k2XP has same functionality as 2XC and 2kxp but does it better and works on modern non-japanese Windows.

## Usage
---------

RM2k2XP has Windows application and cli application which both provide same functionality
but with different interface.

### RM2k2XP CLI

Using RM2k2XP from commandline is simple. To get available commands, use:

	RM2k2XP-cli

To convert chipset to XP format, use

	RM2k2XP-cli C:\mychipset.png --type=chipset
	
To convert charset to XP format, use:

	RM2k2XP-cli C:\mycharset.png --type=charset
	
### RM2k2XP GUI
	
Using Windows application is more straightforward. Just select your input file and press convert button.

## Requirements

* .NET Framework 4.5.2

## Binaries

Latest builds can be found from [here](http://uuksu.kapsi.fi/other/RM2k2XP).

## Building

RM2k2XP will compile with Visual Studio 2015. Output deployment package can be created by running deploy.bat script
from Deploy folder.