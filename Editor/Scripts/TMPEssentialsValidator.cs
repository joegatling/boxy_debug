
using UnityEditor;
using UnityEngine;

namespace JoeGatling.BoxyDebug
{
    [InitializeOnLoad]
    public static class BoxyDebugValidator
    {
        static BoxyDebugValidator()
        {
            if (!AssetDatabase.IsValidFolder("Assets/BoxyDebug"))
            {
                Debug.LogWarning(
                    "Boxy Debug is not installed. " +
                    "Go to Window > Package Manager and install the Boxy Debug package."
                );
            }
        }
    }
}