using HarmonyLib;
using UnityEngine;

namespace CaptainsComms
{
    [HarmonyPatch(typeof(PLIntrepidInfo), "SetupShipStats")]
    internal class IntrepidPatch
    {
        private static void Postfix(PLIntrepidInfo __instance, bool previewStats)
        {
            if (previewStats || !Mod.Config.Intrepid) return;
            GameObject Screen = UsefulMethods.DuplicateCommsScreen(__instance);
            if (Screen == null) return;
            Screen.transform.localPosition = new Vector3(-2.2f, 0.4f, 12.5f);
        }
    }
    [HarmonyPatch(typeof(PLOutriderInfo), "SetupShipStats")]
    internal class OutriderPatch
    {
        private static void Postfix(PLIntrepidInfo __instance, bool previewStats)
        {
            if (previewStats || !Mod.Config.Outrider) return;
            GameObject Screen = UsefulMethods.DuplicateCommsScreen(__instance);
            if (Screen == null) return;
            Screen.transform.localPosition = new Vector3(-1.6f, 2.15f, 2.5f);
            Screen.transform.rotation = Quaternion.Euler(359.9f, 135.64f, 0f);
        }
    }
    [HarmonyPatch(typeof(PLOldWarsShip_Sylvassi), "SetupShipStats")]
    internal class SwordshipPatch
    {
        private static void Postfix(PLIntrepidInfo __instance, bool previewStats)
        {
            if (previewStats || !Mod.Config.Swordship) return;
            GameObject Screen = UsefulMethods.DuplicateCommsScreen(__instance);
            if (Screen == null) return;
            Screen.transform.localPosition = new Vector3(2.17f, 4.78f, 14.08f);
            Screen.transform.rotation = Quaternion.Euler(325.738f, 297.0586f, 0);
        }
    }
}
