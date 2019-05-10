using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

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
			tgt.Update();

			base.OnInspectorGUI();

			// //Display diciontary of connected students
			// var connectedClassmates = GetConnectedClassmates(tgt);
			// // foreach (var cm in connectedClassmates)
			// for (int i = 0; i < connectedClassmates.Count; i++)
			// {
			// 	GUILayout.BeginVertical("Connected Classmates");
			// 	{
			// 		GUILayout.BeginHorizontal();
			// 		{
			// 			GUILayout.Label("text");
			// 		}
			// 		GUILayout.EndHorizontal();
			// 	}
			// 	GUILayout.EndVertical();
			// }

			tgt.ApplyModifiedProperties();
		}

		// private Dictionary<PassDirection, Student> GetConnectedClassmates(SerializedObject obj)
		// {
		// 	// var obj = new SerializedObject(target);
		
		// 	//Find property input strings
		// 	string dictSize = "m_connectedClassmates.Dictionary.size";
		// 	string dictData = "m_connectedClassmates.Dictionary.data[{0}]";
			
		// 	//The size and dictionary itself
		// 	int connectedStudentsDictSize = obj.FindProperty("m_connectedClassmates").intValue;
		// 	var connectedStudentsDict = new Dictionary<PassDirection, Student>();

		// 	//Deserialize and push into new dictionary
		// 	for (int i = 0; i < connectedStudentsDictSize; i++)
		// 	{
		// 		connectedStudentsDict[(PassDirection)i] = obj.FindProperty(string.Format(dictData, i)).objectReferenceValue as Student;
		// 	}

		// 	return connectedStudentsDict;
		// }

		//DEMO REFERENCE CODE
		// public class IntroToEditorScripting : Editor
		// {
		// 	public class Waypoint {}
		// 	private static string arraySizePath = "waypoint.Array.size";
		// 	private static string arrayDataPath = "waypoint.Array.data[{0}]";
		// 	SerializedObject tgt;

		// 	Waypoint[] GetWayPointArray()
		// 	{
		// 		var wpArraySize = tgt.FindProperty(arraySizePath).intValue;
		// 		var wpArray = new Waypoint[wpArraySize];

		// 		for (var i = 0; i < wpArraySize; i++)
		// 		{
		// 			wpArray[i] = tgt.FindProperty(string.Format(arrayDataPath, i)).objectReferenceValue as Waypoint;
		// 		}

		// 		return wpArray;
		// 	}
		// }
		
		void OnSceneGUI()
		{
			tgt.Update();

			tgt.ApplyModifiedProperties();
		}

	}

}