using UnityEngine;
using UnityEditor;
using System;

namespace pokoro
{

    [CustomEditor(typeof(LevelDesigner))]
    public class LevelDesignerEditor : Editor
    {
        LevelDesigner levelDesigner;
        SerializedObject obj;
        SerializedProperty rows;
        SerializedProperty columns;
        SerializedProperty position;
        SerializedProperty padding;


        public void OnEnable()
        {
            obj = new SerializedObject(target);
            rows = obj.FindProperty("rows");
            columns = obj.FindProperty("columns");
            position = obj.FindProperty("position");
            padding = obj.FindProperty("padding");

            levelDesigner = target as LevelDesigner;
        }

        public override void OnInspectorGUI()
        {
            obj.Update();

            DrawDefaultInspector();



            //Randomize students button

            obj.ApplyModifiedProperties();
        }

        void OnSceneGUI()
        {
            obj.Update();

            //Draw position gizmo
            position.vector2Value = Handles.PositionHandle(position.vector2Value, Quaternion.identity);

            Handles.BeginGUI();
            {
                //Generate students button
                if (GUILayout.Button("Generate Students", GUILayout.Width(150)))
                {
                    levelDesigner.GenerateStudents();
                }
            }
            Handles.EndGUI();

            obj.ApplyModifiedProperties();
        }


        ////----------------------------- Other Messages ------------------------------
        //Implement to create your own interactive custom preview. Interactive custom previews 
        //are used in the preview area of the inspector and the object selector.
        public override void OnInteractivePreviewGUI(Rect r, GUIStyle background)
        {
        }
        //Implement to create your own custom preview for the preview area of the inspector
        public override void OnPreviewGUI(Rect r, GUIStyle background)
        {
        }
        //Override this method if you want to shw custom controls int he preview header
        public override void OnPreviewSettings()
        {
        }
    }

}


// //GUI 
// public struct GUISpecs
// {
// 	public float[] width;
// }
// float[] guiWidth = { 60f, 60f };
// //Draw GUI at top left to select rows, columns and other
// 	Handles.BeginGUI();
// 	{
// 		//Rows & Columns
// 		EditorGUILayout.BeginHorizontal(GUILayout.MaxWidth(guiWidth[0] + guiWidth[1]));
// 		{
// 			GUILayout.Label("Rows", GUILayout.Width(guiWidth[0]));
// 			T.rows = EditorGUILayout.DelayedIntField(T.rows, GUILayout.Width(guiWidth[1]));
// 		}
// 		EditorGUILayout.EndHorizontal();
// 		EditorGUILayout.BeginHorizontal(GUILayout.MaxWidth(guiWidth[0] + guiWidth[1]));
// 		{
// 			GUILayout.Label("Columns", GUILayout.Width(guiWidth[0]));
// 			T.columns = EditorGUILayout.DelayedIntField(T.columns, GUILayout.Width(guiWidth[1]));
// 		}
// 		EditorGUILayout.EndHorizontal();

// 		//Paddings
// 		EditorGUILayout.BeginHorizontal(GUILayout.MaxWidth(guiWidth[0] + guiWidth[1]));
// 		{
// 			GUILayout.Label("X Padding", GUILayout.Width(guiWidth[0]));
// 			T.posNpad.width = EditorGUILayout.DelayedFloatField(T.posNpad.width, GUILayout.Width(guiWidth[1]));
// 		}
// 		EditorGUILayout.EndHorizontal();
// 		EditorGUILayout.BeginHorizontal(GUILayout.MaxWidth(guiWidth[0] + guiWidth[1]));
// 		{
// 			GUILayout.Label("Y Padding", GUILayout.Width(guiWidth[0]));
// 			T.posNpad.height = EditorGUILayout.DelayedFloatField(T.posNpad.height, GUILayout.Width(guiWidth[1]));
// 		}
// 		EditorGUILayout.EndHorizontal();

// 		if (GUILayout.Button("Populate Classroom",
// 			EditorStyles.miniButton,
// 			GUILayout.Width(guiWidth[0] + guiWidth[1]),
// 			GUILayout.Height(25)))
// 		{

// 		}

// 		if (GUILayout.Button("Randomize Appearance", 
// 			EditorStyles.miniButton, 
// 			GUILayout.Width(guiWidth[0] + guiWidth[1]), 
// 			GUILayout.Height(25)))
// 		{
// 			StudentManager.RandomizeAllStudentAppearances();
// 		}
// 	}
// 	Handles.EndGUI();