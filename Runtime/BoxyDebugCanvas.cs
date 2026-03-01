using UnityEngine;
using UnityEngine.UIElements;

namespace JoeGatling.BoxyDebug
{
    public class BoxyDebugCanvas
    {
        protected Canvas _canvas;

        public static BoxyDebugCanvas Create()
        {
            var canvasGameObject = new GameObject("BoxyDebugCanvas");
            Object.DontDestroyOnLoad(canvasGameObject);
            var canvas = canvasGameObject.AddComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            canvas.sortingOrder = 1000; // Ensure it's on top of other UI

            var boxyDebugCanvas = new BoxyDebugCanvas();
            boxyDebugCanvas._canvas = canvas;

            return boxyDebugCanvas;
        }

        public Canvas Canvas { get { return _canvas; } }
    }
}
