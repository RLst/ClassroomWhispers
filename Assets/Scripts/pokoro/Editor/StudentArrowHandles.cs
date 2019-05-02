using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Student))]
public class StudentArrowHandles : Editor {

	void OnSceneGUI()
	{
		//Retrieve the student
		Student tar = target as Student;

		//Put
	}

}