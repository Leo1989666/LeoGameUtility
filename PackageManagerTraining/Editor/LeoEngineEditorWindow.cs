using UnityEditor;

namespace Leo
{
    public class LeoEngineEditorWindow : EditorWindow
    {
        [MenuItem("Leo/LeoWindow")]
        private static void initWindow()
        {
            LeoEngineEditorWindow _window = (LeoEngineEditorWindow)EditorWindow.GetWindow(typeof(LeoEngineEditorWindow));
            _window.Show();
        }
    }    
}
