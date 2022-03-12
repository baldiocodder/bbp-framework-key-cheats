using System;
using BepInEx;
using HarmonyLib;

namespace KeyCheats.Main
{
    [BepInPlugin("b99.tbb.baldiplus.keycheats", "Key Cheats for Plus", "1.0.0.0")]
    public class BasePlugin : BaseUnityPlugin
    {
        void Awake()
        {
            Harmony harmony = new Harmony("b99.tbb.baldiplus.keycheats");
            harmony.PatchAll();
        }
    }
}
