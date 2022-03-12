using System;
using UnityEngine;
using HarmonyLib;

namespace KeyCheats.Plugins
{
    [HarmonyPatch(typeof(ItemManager))]
    [HarmonyPatch("RemoveItem")]
    class InventoryInfinitePatch
    {
        static bool Prefix()
        {
            return !IventoryInfiniteCheckerPatch.isAvailable;
        }
    }
}
