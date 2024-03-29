﻿using HarmonyLib;
using PulsarModLoader;
using PulsarModLoader.CustomGUI;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace CaptainsComms
{
    public class Mod : PulsarMod
    {
        public override string HarmonyIdentifier() => "Mest.CaptainsComms";
        public override string Name => "Captains Comms";
        public override string Author => "Mest";
        public override string Version => "0.1.2";
        public override string ShortDescription => "Moves comms screen to an accessible location";
        internal class Config : ModSettingsMenu
        {
            public override string Name() => "Captains Comms Config";
            public override void Draw()
            {
                GUILayout.Label("<b><color=yellow>Rejoining will spawn/despawn screens</color></b>");
                GUILayout.BeginHorizontal();
                Intrepid.Value = GUILayout.Toggle(Intrepid.Value, "Intrepid Comms Screen");
                Roland.Value = GUILayout.Toggle(Roland.Value, "Roland Comms Screen");
                Outrider.Value = GUILayout.Toggle(Outrider.Value, "Outrider Comms Screen");
                GUILayout.EndHorizontal();
                GUILayout.BeginHorizontal();
                //Cruiser.Value = GUILayout.Toggle(Cruiser.Value, "Cruiser Comms Screen");
                Destroyer.Value = GUILayout.Toggle(Destroyer.Value, "Destroyer Comms Screen");
                Carrier.Value = GUILayout.Toggle(Carrier.Value, "Carrier Comms Screen");
                GUILayout.EndHorizontal();
                GUILayout.BeginHorizontal();
                Swordship.Value = GUILayout.Toggle(Swordship.Value, "Swordship Comms Screen");
                IntrepidSC.Value = GUILayout.Toggle(IntrepidSC.Value, "Intrepid SC Comms Screen");
                //FluffyOne.Value = GUILayout.Toggle(FluffyOne.Value, "FluffyOne Comms Screen");
                GUILayout.EndHorizontal();
            }
            public static SaveValue<bool> Intrepid = new SaveValue<bool>("Intrepid", true);
            public static SaveValue<bool> Roland = new SaveValue<bool>("Roland", true);
            public static SaveValue<bool> Outrider = new SaveValue<bool>("Outrider", true);
            public static SaveValue<bool> Cruiser = new SaveValue<bool>("Cruiser", true);
            public static SaveValue<bool> Destroyer = new SaveValue<bool>("Destroyer", true);
            public static SaveValue<bool> Carrier = new SaveValue<bool>("Carrier", true);
            public static SaveValue<bool> Swordship = new SaveValue<bool>("Swordship", true);
            public static SaveValue<bool> FluffyOne = new SaveValue<bool>("FluffyOne", true);
            public static SaveValue<bool> IntrepidSC = new SaveValue<bool>("IntrepidSC", true);
        }
    }
    public class UsefulMethods
    {
        public static GameObject DuplicateCommsScreen(PLShipInfo __instance)
        {
            foreach (PLCommsScreen pLCommsScreen in __instance.InteriorDynamic.GetComponentsInChildren<PLCommsScreen>())
            {
                if (pLCommsScreen == null) continue;
                GameObject Screen = GameObject.Instantiate(pLCommsScreen.gameObject);
                Screen.transform.parent = pLCommsScreen.transform.parent;
                Screen.layer = pLCommsScreen.gameObject.layer;
                Screen.transform.position = __instance.CaptainsChairPivot.transform.position;
                return Screen;
            }
            return null;
        }
    }
    [HarmonyPatch(typeof(PLCommsScreen), "Update")]
    internal class WhiteBarRemoval
    {
        private static void Prefix(PLCommsScreen __instance)
        {
            if (__instance != null && __instance.name.Contains("(Clone)") && __instance.transform.GetChildCount() == 4)
            {
                __instance.transform.GetChild(1).gameObject.SetActive(false);
            }
        }
    }
}
