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
			tgt.Update();

			base.OnInspectorGUI();
			
			// //Display diciontary of connected students
			// var connectedStudents = tgt.FindProperty("connectedStudents");
			// foreach (var cs in tgt.)

			tgt.ApplyModifiedProperties();
        }

        void OnSceneGUI()
        {
            tgt.Update();

            tgt.ApplyModifiedProperties();
        }

    }


	public class IntroToEditorScripting : Editor
	{
		public class Waypoint {}
		private static string arraySizePath = "waypoint.Array.size";
		private static string arrayDataPath = "waypoint.Array.data[{0}]";
		SerializedObject tgt;
		
		Waypoint[] GetWayPointArray()
		{
			var wpArraySize = tgt.FindProperty(arraySizePath).intValue;
			var wpArray = new Waypoint[wpArraySize];

			for (var i = 0; i < wpArraySize; i++)
			{
				wpArray[i] = tgt.FindProperty(string.Format(arrayDataPath, i)).objectReferenceValue as Waypoint;
			}

			return wpArray;
		}
	}
}