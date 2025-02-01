using HarmonyLib;
using PlayerRoles.FirstPersonControl;
using UnityEngine;

[HarmonyPatch(typeof(FpcMotor), "ApplyMovementModifiers")]
public class SpeedPatch
{
    static void Postfix(ref Vector3 movement)
    {
        movement *= 2f; // مضاعفة سرعة اللاعب
    }
}