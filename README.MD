# RM2k2XP

**Active development and support has come to an end! Developing this would require a conversion to a modern .NET version. If you would like to see new features and are willing to develop them, please contact me to negotiate repository maintenance rights.**

RM2k2XP can be used to convert old RPG Maker 2000/2003 styled charset and chipset to XP format.

RM2k2XP has same functionality as 2XC and 2kxp but does it better and works on modern non-japanese Windows.

## Usage

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
	
Using Windows application is more straightforward. Just select chipset or charset, your input file and output directory and press convert button.

## Requirements

* .NET Framework 4.8

## Binaries

Latest builds can be found from [here](https://github.com/uuksu/RM2k2XP/releases).

## Building

RM2k2XP will compile with latest Visual Studio. Output deployment package can be created by running deploy.bat script from Deploy folder.
