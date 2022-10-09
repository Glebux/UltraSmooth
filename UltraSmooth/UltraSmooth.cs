using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using HarmonyLib;
using UnityEngine;
namespace UltraSmooth
{
    [BepInPlugin(modGuid, modName, modVersion)]
    [BepInProcess("ULTRAKILL.exe")]
    public class UltraSmooth : BaseUnityPlugin
    {
        private const string modGuid = "Glebux.UltraSmooth";
        private const string modName = "UltraSmooth By Glebux";
        private const string modVersion = "1.0.0.0";
        private readonly Harmony harmony = new Harmony(modGuid);
        void Awake()
        {
            harmony.PatchAll();
        }
        [HarmonyPatch(typeof(TimeController), nameof(TimeController.TrueStop))]
        class TrueStop_patch
        {
            static bool Prefix()
            {
                return false;
            }
        }
        [HarmonyPatch(typeof(TimeController), nameof(TimeController.SlowDown))]
        class SlowDown_patch
        {
            static bool Prefix()
            {
                return false;
            }
        }
        [HarmonyPatch(typeof(TimeController), nameof(TimeController.HitStop))]
        class HitStop_patch
        {
            static bool Prefix()
            {
                return false;
            }
        }
    }
}
