using System;
using UnityEngine;
using HarmonyLib;

namespace KeyCheats.Plugins
{
    [HarmonyPatch(typeof(PlayerMovement))]
    [HarmonyPatch("StaminaUpdate")]
    class PlayerInfiniteRunPatch
    {
        static bool infrun;
        static bool Prefix()
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                infrun = !infrun;
            }
            return !infrun;
        }
    }
}

