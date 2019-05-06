using UnityEditor;
using UnityEngine;

namespace pokoro
{
public class LevelDesignerSceneEditor : Editor 
{
	SerializedObject obj;
	SerializedProperty rows;
	SerializedProperty columns;
	SerializedProperty posNpad;

	void OnEnabled()
	{
		obj = new SerializedObject(target);
		rows = obj.FindProperty("rows");
		columns = obj.FindProperty("columns");
		posNpad = obj.FindProperty("positionAndPadding");
		
	}

	void OnSceneGUI()
	{
		//Grab target properties
		obj.Update();

		Handles.BeginGUI();
		{
			EditorGUILayout.PropertyField(posNpad);
		}
		Handles.EndGUI();

		obj.ApplyModifiedProperties();
	}
}
}
