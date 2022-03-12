using System;
using UnityEngine;
using HarmonyLib;

namespace KeyCheats.Plugins
{
    [HarmonyPatch(typeof(ItemManager))]
    [HarmonyPatch("Update")]
    class IventoryInfiniteCheckerPatch
    {
        public static bool isAvailable;
        static bool Prefix()
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                isAvailable = !isAvailable;
            }
            return true;
        }
    }
}
