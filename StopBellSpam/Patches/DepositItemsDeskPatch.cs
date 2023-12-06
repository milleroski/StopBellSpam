using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace StopBellSpam.Patches
{
    internal class DepositItemsDeskPatch
    {
        [HarmonyPatch(typeof(DepositItemsDesk), "Update")]
        [HarmonyPostfix]
        static void DepositItemsPatch(ref float ___patienceLevel)
        {
            ___patienceLevel = 3f;
        }

    }
}
