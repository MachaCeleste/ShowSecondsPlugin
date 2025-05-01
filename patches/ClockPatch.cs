using HarmonyLib;

[HarmonyPatch]
public class ClockPatch
{
    [HarmonyPatch(typeof(Clock), "GetFormatHora")]
    class GetFormatHoraPatch
    {
        static bool Prefix(ref Clock __instance, ref string __result)
        {
            __result = __instance.GetDateTime().ToString("HH:mm:ss");
            return false;
        }
    }
}