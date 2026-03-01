using UnityEngine;
using TMPro;
using System;

namespace JoeGatling.BoxyDebug
{


    public class BoxyDebugLabel : BoxyDebugElement
    {
        [Header("Internal References")]
        [SerializeField] private TextMeshProUGUI _label;
        [SerializeField] private TextMeshProUGUI _value;
        private Func<string> _valueFunction;

        public void Intialize(string label, System.Func<string> valueFunction)
        {
            _label.text = label;

            name = $"Label: {label}";

            if(valueFunction == null)
            {
                _value.text = "NULL";
                return;
            }
            else
            {
                _valueFunction = valueFunction;
                _value.text = valueFunction.Invoke();
            }
        }

        // Update is called once per frame
        void Update()
        {
            if(_valueFunction != null)
            {
                _value.text = _valueFunction.Invoke();
            }   
        }
    }
}
