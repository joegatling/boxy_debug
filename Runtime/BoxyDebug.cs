using UnityEngine;

namespace JoeGatling.BoxyDebug
{
    public class BoxyDebug
    {
        public static BoxyDebug Instance { get; private set; }

        private static BoxyDebugCanvas _canvas;

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void Initialize()
        {
            Instance = new BoxyDebug();
            _canvas = BoxyDebugCanvas.Create();            
        }




    }
}
