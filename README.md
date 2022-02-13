# BalancedDifficultySettings
This is a Mod for Pathfinder Kingmaker
Author: Gabriel A. Tiraboschi

Before this mod when you select different options in the setting “Enemy difficulty”, the enemies in the game get +2AC and Attack Bonus, as well as +4 to all ability scores for each increase in the difficulty level (e.g., from Normal to Strengthened). If you give a monster +2 to AC and Attack Bonus and +4 to all ability scores, in reality, that gives the monsters +4 to hit your party and +4 to avoid your party’s attacks. I think that it is too much, and I always wanted more fine-tuning settings. That’s where I had the idea for this mod. With this mod, you can replace these bonuses. By default, this mod replaces the vanilla values to +1 to AC and Attack Bonus (instead of +2) and +2 to all ability scores (instead of +4). This gives monsters +2 to hit and to avoid attacks for each level of increase in the “Enemy difficulty”﻿ setting. However, you can change these values to whatever you like, just open the “Settings.csv” file with Excel or LibreOffice and change the values. However, I should note that I have not tested other values.

To check what each option was originally intended to do by the devs, see: https://steamcommunity.com/app/640820/discussions/0/1730963192537352029/

The instant that you turn off the mod the enemies will have the default bonus values. You can switch on and off as you play the game, no need to restart the game. And I don’t believe this mod will affect your saves, but I have not tested this extensively, therefore I cannot guarantee.

This mod has been tested with the 2.1.5d version of the game.
 
Here is an example of what the mod does:
--
With “Enemy difficulty” and “Enemy Stat Adjustment” set to both normal, the Giant Slug (lvl
12 Vermin) has the following stats:

Initiative-4
STR 27           DEX 2             CON 18          INT 10             WIS 10           CHA 1
Hit points 114
AC 20             Flat-footed 20             Touch 4
Fortitude+12              Will +4           Reflex +0
--
In the vanilla game if you select the option “Strengthened” in “Enemy difficulty” and
keep the “Enemy Stat Adjustment” to normal, the Giant Slug (lvl 12 Vermin) has
the following stats:

Initiative-2
STR 31           DEX 6             CON 22          INT 10             WIS 14           CHA 5
Hit points 138
AC 24             Flat-footed 24             Touch 8
Fortitude+14              Will +6           Reflex +2

Note that here the giant slug gets +4 to all attributes (which gives +2 to AC and attack) plus an additional +2 to AC and Attack.
--
With this mod, you can now replace this bonus from the difficulty setting. Using the default settings (+2 to attributes and +1 to AC and Attack) the same Giant Slug is now (using the option “Strengthened” in “Enemy difficulty” and keeping the “Enemy Stat Adjustment” to normal):

Initiative-2
STR 29           DEX 4             CON 20          INT 10             WIS 12           CHA 3
Hit points 126 
AC 22             Flat-footed 22             Touch 6
Fortitude+13              Will +5           Reflex +1
--
 
This mod is mainly focused on the “Enemy difficulty” settings. However, it does interfere with the “Enemy Stat Adjustment” setting as well, because the “Somewhat easier enemies” and the “Somewhat tougher enemies” options in the vanilla game give a bonus/penalty of +2 to enemy attack and AC (no bonuses to attributes). This mod replaces this bonus/penalty to AC and attacks with the value set in the "Settings.csv" file. Hence, with this mod by default, the monsters get +1 to AC and attack in the “Somewhat tougher enemies” option. Enemies get +3 to hit and AC if you are playing the game in the Hard difficulty settings (which sets “Enemy Stat Adjustment” to “Somewhat tougher enemies” and “Enemy difficulty” to “Strengthened”).

--
How to Install
Download and install Unity Mod Manager﻿
Download the mod
Install the mod with Unity Mod Manager by dropping the "*.zip" file in the UMM.
Run the game and make sure that the mod is active in UMM.
