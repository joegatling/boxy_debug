using UnityEngine;

namespace JoeGatling.BoxyDebug
{
    /// <summary>
    /// A simple debug overlay for Unity projects.
    /// Attach this component to a GameObject in your scene to display debug information on screen.
    /// </summary>
    public class BoxyDebug : MonoBehaviour
    {
        [SerializeField] private bool _showOverlay = true;
        [SerializeField] private int _fontSize = 14;
        [SerializeField] private Color _textColor = Color.white;

        private GUIStyle _labelStyle;

        private void OnGUI()
        {
            if (!_showOverlay)
                return;

            if (_labelStyle == null)
            {
                _labelStyle = new GUIStyle(GUI.skin.label)
                {
                    fontSize = _fontSize,
                    normal = { textColor = _textColor }
                };
            }

            GUILayout.BeginVertical();
            GUILayout.Label($"FPS: {(int)(1.0f / Time.smoothDeltaTime)}", _labelStyle);
            GUILayout.Label($"Time: {Time.time:F2}s", _labelStyle);
            GUILayout.EndVertical();
        }
    }
}
