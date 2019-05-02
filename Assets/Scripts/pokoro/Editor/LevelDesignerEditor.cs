using UnityEngine;
using UnityEditor;

namespace pokoro
{

    [CustomEditor(typeof(LevelDesigner))]
    public class LevelDesignerEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            LevelDesigner tar = target as LevelDesigner;

            //These are essentially the same
            // DrawDefaultInspector();
            // base.OnInspectorGUI();


            //Implement this function to make a custom inspector
            EditorGUILayout.DelayedTextField("delayedTextField", GUILayout.Width(100), GUILayout.Height(100));

            Handles.DrawArrow();
    
    }

        void OnGUI()
        {

        }

        void OnSceneGUI()
        {

        }


        public override void OnInteractivePreviewGUI(Rect r, GUIStyle background)
        {
            //Implement to create your own interactive custom preview. Interactive custom previews 
            //are used in the preview area of the inspector and the object selector.
        }
        public override void OnPreviewGUI(Rect r, GUIStyle background)
        {
            //Implement to create your own custom preview for the preview area of the inspector
        }
        public override void OnPreviewSettings()
        {
            //Override this method if you want to shw custom controls int he preview header
        }
    }

}