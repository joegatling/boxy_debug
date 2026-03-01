
using UnityEditor;
using UnityEngine;

namespace JoeGatling.BoxyDebug
{
    [InitializeOnLoad]
    public static class TMPValidation
    {
        static TMPValidation()
        {
            if (!AssetDatabase.IsValidFolder("Assets/TextMesh Pro"))
            {
                Debug.LogWarning(
                    "TextMesh Pro Essentials are not installed. " +
                    "Go to Window > TextMeshPro > Import TMP Essential Resources."
                );
            }
        }
    }
}