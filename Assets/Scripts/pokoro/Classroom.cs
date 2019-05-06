using UnityEngine;

namespace pokoro
{
[CreateAssetMenu(fileName = "Classroom", menuName = "Managers/Classroom")]
public class Classroom : ScriptableObject 
{
	
	[SerializeField] GameObject studentPrefab;
	public Student[] students;

	
	public static void RandomizeAllStudentAppearances()
	{
		Debug.Log("Randomizing Students!");
	}

	public static void GenerateStudents()
	{
		Debug.Log("Generating Classroom");

		//Make students out of prefabs and then 
		
	}
}
}