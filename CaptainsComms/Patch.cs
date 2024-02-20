using HarmonyLib;
using UnityEngine;

namespace CaptainsComms
{
    [HarmonyPatch(typeof(PLIntrepidCommanderInfo), "SetupShipStats")]
    internal class IntrepidSCPatch
    {
        private static void Postfix(PLIntrepidCommanderInfo __instance, bool previewStats)
        {
            if (previewStats || !Mod.Config.IntrepidSC) return;
            GameObject Screen = UsefulMethods.DuplicateCommsScreen(__instance);
            if (Screen == null) return;
            Screen.transform.localPosition = new Vector3(-2.2f, 0.4f, 12.5f);
        }
    }
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
    [HarmonyPatch(typeof(PLRolandInfo), "SetupShipStats")]
    internal class RolandPatch
    {
        private static void Postfix(PLRolandInfo __instance, bool previewStats)
        {
            if (previewStats || !Mod.Config.Roland) return;
            GameObject Screen = UsefulMethods.DuplicateCommsScreen(__instance);
            if (Screen == null) return;
            Screen.transform.localPosition = new Vector3(1.524f, 19.584f, 42.54f);
            Screen.transform.rotation = Quaternion.Euler(0, 307, 0);
        }
    }
    [HarmonyPatch(typeof(PLOutriderInfo), "SetupShipStats")]
    internal class OutriderPatch
    {
        private static void Postfix(PLOutriderInfo __instance, bool previewStats)
        {
            if (previewStats || !Mod.Config.Outrider) return;
            GameObject Screen = UsefulMethods.DuplicateCommsScreen(__instance);
            if (Screen == null) return;
            Screen.transform.localPosition = new Vector3(-1.6f, 2.15f, 2.5f);
            Screen.transform.rotation = Quaternion.Euler(359.9f, 135.64f, 0f);
        }
    }
    [HarmonyPatch(typeof(PLWDDestroyerInfo), "SetupShipStats")]
    internal class DestroyerPatch
    {
        private static void Postfix(PLWDDestroyerInfo __instance, bool previewStats)
        {
            if (previewStats || !Mod.Config.Destroyer) return;
            GameObject Screen = UsefulMethods.DuplicateCommsScreen(__instance);
            if (Screen == null) return;
            Screen.transform.localPosition = new Vector3(1.426f, 4.196f, -10.242f);
            Screen.transform.rotation = Quaternion.Euler(0, 313, 0);
        }
    }
    [HarmonyPatch(typeof(PLCarrierInfo), "SetupShipStats")]
    internal class CarrierPatch
    {
        private static void Postfix(PLCarrierInfo __instance, bool previewStats)
        {
            if (previewStats || !Mod.Config.Carrier) return;
            GameObject Screen = UsefulMethods.DuplicateCommsScreen(__instance);
            if (Screen == null) return;
            Screen.transform.localPosition = new Vector3(-3.56f, 17.453f, 65.575f);
            Screen.transform.rotation = Quaternion.Euler(0, 90, 0);
        }
    }
    [HarmonyPatch(typeof(PLAlchemistShipInfo), "SetupShipStats")]
    internal class AlchemistPatch
    {
        private static void Postfix(PLAlchemistShipInfo __instance, bool previewStats)
        {
            if (previewStats || !Mod.Config.Alchemist) return;
            GameObject Screen = UsefulMethods.DuplicateCommsScreen(__instance);
            if (Screen == null) return;
            Screen.transform.localPosition = new Vector3(-3.56f, 17.453f, 65.575f);
            Screen.transform.rotation = Quaternion.Euler(0, 90, 0);
        }
    }
    [HarmonyPatch(typeof(PLOldWarsShip_Sylvassi), "SetupShipStats")]
    internal class SwordshipPatch
    {
        private static void Postfix(PLOldWarsShip_Sylvassi __instance, bool previewStats)
        {
            if (previewStats || !Mod.Config.Swordship) return;
            GameObject Screen = UsefulMethods.DuplicateCommsScreen(__instance);
            if (Screen == null) return;
            Screen.transform.localPosition = new Vector3(2.55f, 5.588f, 14.78f);
            Screen.transform.rotation = Quaternion.Euler(0, 280, 0);
        }
    }
}
