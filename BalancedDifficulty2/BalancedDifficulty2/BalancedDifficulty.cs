using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using UnityEngine;
using HarmonyLib;
using UnityModManagerNet;
using System.Reflection;
using Kingmaker.Designers.Mechanics.Buffs;

namespace BalancedDifficulty2
{
    public class Main
    {
        //Constants
        private const string PATH = "Mods/Balanced Difficulty/Settings.csv";
        //Properties
        public static bool enabled;
        public static UnityModManager.ModEntry mod;
        public static int BasicStatBonus { get; private set; }
        public static int DerivativeStatBonus { get; private set; }


        static bool Load(UnityModManager.ModEntry modEntry)
        {
            var harmony = new Harmony(modEntry.Info.Id);
            harmony.PatchAll(Assembly.GetExecutingAssembly());

            mod = modEntry;
            modEntry.OnToggle = OnToggle;

            return true;
        }

        static bool OnToggle(UnityModManager.ModEntry modEntry, bool value)
        {
            enabled = value;

            //Try to read the settings
            try
            {
                using (var sr = new StreamReader(PATH, Encoding.UTF8))
                {
                    /*
                     * Here we have to be extra carreful because if the file is being
                     * used by the system it won't read.
                     */
                    sr.ReadLine();
                    string[] attibutes = sr.ReadLine().Split(',');
                    sr.Close();
                    BasicStatBonus = int.Parse(attibutes[0]);
                    DerivativeStatBonus = int.Parse(attibutes[1]);

                }
            }
            catch (Exception e)
            {
                mod.Logger.Error(e.ToString());
            }
            
            
            return true;
        }
    }

    [HarmonyPatch(typeof(DifficultyStatAdvancement), "OnTurnOn")]
    class BalancedDifficulty
    {

        static void Prefix(DifficultyStatAdvancement __instance)
        {
            if (Main.enabled != true)
                return;

            try
            {
                /*
                 * this changes the stats bonus from 4 to 2
                 * and the AC and Attack bonus to 1.
                 * These bonus are customized in the option Enemy Difficulty.
                 * However, some levels in Enemy Stat ajustment option also give bonus to AC and Attack.
                 * This also change this bonus.
                 */
                __instance.BasicStatBonus = Main.BasicStatBonus;
                __instance.DerivativeStatBonus = Main.DerivativeStatBonus;
            }
            catch (Exception e)
            {
                Main.mod.Logger.Error(e.ToString());
            }

        }
    }
}
