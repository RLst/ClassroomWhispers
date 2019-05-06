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

        [SerializeField] int rows = 2;
        [SerializeField] int columns = 4;
        [SerializeField] Vector2 position = new Vector2(0, 0);
        [SerializeField] Vector2 padding = new Vector2(2, 2);

        [SerializeField] GameObject studentPrefab;


        void OnDrawGizmos()
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
                    Vector2 limboPos = new Vector2(position.x + i * padding.x, position.y + j * padding.y);

                    //Draw the gizmo
                    Gizmos.DrawIcon(limboPos, "basic-gizmo-icon.png", true);
                }
            }
        }

		//Makes a classroom of students from a student prefab
        public void GenerateStudents()
        {
            if (studentPrefab != null)
            {
                //Make an empty classroom game object on the root
                var classroom = new GameObject("Classroom");
                classroom.transform.SetParent(null);

                //Create an array of students at marker locations
                for (int i = 0; i < columns; i++)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        //Calculate the position for the gizmo
                        Vector2 limboStudentPos = new Vector2(position.x + i * padding.x, position.y + j * padding.y);

                        //Create the student
                        var limboStudent = Instantiate(studentPrefab, limboStudentPos, Quaternion.identity);

                        //Child to the classroom
                        limboStudent.transform.SetParent(classroom.transform);
                    }
                }
            }
        }
    }
}