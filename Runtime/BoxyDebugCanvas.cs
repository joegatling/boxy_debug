using UnityEngine;
using UnityEngine.UIElements;

namespace JoeGatling.BoxyDebug
{
    public class BoxyDebugCanvas : MonoBehaviour
    {
        [SerializeField] protected Canvas _canvas;

        public Canvas Canvas { get { return _canvas; } }
    }
}
