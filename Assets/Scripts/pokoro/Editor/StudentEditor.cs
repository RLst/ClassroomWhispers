using UnityEngine;
using UnityEditor;

namespace pokoro
{
    [CustomEditor(typeof(Student))]
    public class StudentEditor : Editor
    {
        SerializedObject tgt;
        
        void OnEnable()
        {
            tgt = new SerializedObject(target);
        }

        public override void OnInspectorGUI()
        {
			base.OnInspectorGUI();
        }

        void OnSceneGUI()
        {
            tgt.Update();

            tgt.ApplyModifiedProperties();
        }

    }
}