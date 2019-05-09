using System;
using UnityEngine;

namespace pokoro
{
public class LevelDesigner : MonoBehaviour
// public class LevelDesigner : MonoBehaviour
{
    ////Maybe this class should be called either 'StudentBuilder' or 'Classroom' or 'ClassroomManager'
    // + GenerateClassroom : void
    //	Generates a 'classroom' of students out of:
    //	1. StudentPrefab : GameObject
    //	2. rows, columns, posNpadding parameters

    [Header("Classroom Config")]
    [SerializeField] int rows = 2;
    [SerializeField] int columns = 4;
    // [SerializeField] Vector2 position;
    public Vector2 padding = new Vector2(2, 2);

    [Header("Create")]
    [SerializeField] GameObject studentPrefab;


    //Makes a classroom of students from a student prefab
    public void GenerateStudents()
    //This is better here because this tool has access to position, rows/columns, padding etc 
    {
        if (studentPrefab != null)
        {
            //Find a classroom
            var limboClassroom = FindObjectOfType<Classroom>();

            //Create a classroom if it doesn't exist
            if (limboClassroom == null)
            {
                //Make an empty classroom game object on the root
                var limboClassroomObj = new GameObject("Classroom");
                limboClassroomObj.transform.SetParent(null);

                //Add a classroom object
                limboClassroom = limboClassroomObj.AddComponent<Classroom>() as Classroom;
            }

            //Create an array of students at marker locations
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    //Calculate the position for the gizmo
                    Vector2 limboStudentPos = new Vector2(transform.position.x + i * padding.x, transform.position.y + j * padding.y);

                    //Create the student
                    var limboStudent = Instantiate(studentPrefab, limboStudentPos, Quaternion.identity);

                    //Child to the classroom
                    limboStudent.transform.SetParent(limboClassroom.transform);
                }
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        DisplayStudentNodeMarkers();
    }

    private void DisplayStudentNodeMarkers()
    {
        //Draw visual markers for each student position
        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                //Calculate the position for the gizmo
                Vector2 limboPos = new Vector2(transform.position.x + i * padding.x, transform.position.y + j * padding.y);

                //Draw the gizmo
                Gizmos.DrawIcon(limboPos, "marker-crosshair.png", false);
            }
        }
    }

}
}