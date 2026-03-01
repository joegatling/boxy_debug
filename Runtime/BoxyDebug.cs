using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace JoeGatling.BoxyDebug
{
    public class BoxyDebug
    {
        public static BoxyDebug Instance { get; private set; }

        public static BoxyDebugConfiguration configuration { get; private set; }

        protected BoxyDebugCanvas _canvas;
        protected Dictionary<string, BoxyDebugElement> _elements = new Dictionary<string, BoxyDebugElement>();

        protected BoxyDebugInputActions _inputActions;

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void Initialize()
        {
            Instance = new BoxyDebug();

            
        }   

        private BoxyDebug()
        {
            configuration = Resources.Load<BoxyDebugConfiguration>("BoxyDebugConfiguration");

            if(configuration == null)
            {
                Debug.LogError("BoxyDebugConfiguration asset not found in Resources folder. Please create one using the Create menu.");
                return;
            }

            _canvas = GameObject.Instantiate<BoxyDebugCanvas>(configuration.CanvasPrefab);
            _canvas.name = "BoxyDebugCanvas";
            Object.DontDestroyOnLoad(_canvas.gameObject);

            _inputActions = new BoxyDebugInputActions();
            _inputActions.Core.Toggle.performed += ctx => ToggleDebugDisplay();
            _inputActions.Core.Toggle.Enable();  
    }

        private void ToggleDebugDisplay()
        {
            _canvas.Canvas.enabled = !_canvas.Canvas.enabled;
        }

        public void AddLabel(string label, System.Func<string> valueFunction)
        {
            if(_elements.ContainsKey(label))
            {
                RemoveElement(label);
            }

            BoxyDebugLabel newLabel = GameObject.Instantiate<BoxyDebugLabel>(configuration.LabelPrefab, _canvas.transform);
            newLabel.Intialize(label, valueFunction);
            _elements.Add(label, newLabel);
        }

        public void RemoveElement(string label)
        {
            if(!_elements.ContainsKey(label))
            {
                return;
            }

            BoxyDebugElement element = _elements[label];
            GameObject.Destroy(element.gameObject);
            _elements.Remove(label);
        }




    }
}
