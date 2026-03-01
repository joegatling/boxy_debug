using UnityEngine;

namespace JoeGatling.BoxyDebug
{
    [CreateAssetMenu(fileName = "BoxyDebugConfiguration", menuName = "Scriptable Objects/BoxyDebugConfiguration")]
    public class BoxyDebugConfiguration : ScriptableObject
    {
        [Header("System Prefabs")]
        [SerializeField] private BoxyDebugCanvas _canvasPrefab;

        [Header("Element Prefabs")]
        [SerializeField] private BoxyDebugLabel _labelPrefab;

        public BoxyDebugCanvas CanvasPrefab { get { return _canvasPrefab; } }
        public BoxyDebugLabel LabelPrefab { get { return _labelPrefab; } }


    }
}
