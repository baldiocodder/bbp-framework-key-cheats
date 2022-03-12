using System;
using UnityEngine;
using HarmonyLib;

namespace KeyCheats.Plugins
{
    [HarmonyPatch(typeof(PlayerMovement))]
    [HarmonyPatch("Update")]
    class PlayerNoClipPatch
    {
        static bool noclipin;
        static bool Prefix()
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                Singleton<CoreGameManager>.Instance.AddPoints(100, 0, true);
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                noclipin = !noclipin;
                SwitchNoClip(noclipin);
            }
            return true;
        }
        public static void SwitchNoClip(bool noclip)
        {
            foreach (Collider collider in Resources.FindObjectsOfTypeAll<Collider>())
            {
                Physics.IgnoreCollision(Singleton<CoreGameManager>.Instance.GetPlayer(0).GetComponent<Collider>(), collider, noclip);
            }
        }
    }
}
