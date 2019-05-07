using System.Collections.Generic;
using UnityEngine;

namespace pokoro.Architecture
{

    public class Architecture : MonoBehaviour { }

    public class LevelDesigner
    {
        //Editor based class to assist in designing the level
        StudentManager studentManager;

        public class Gun
        {
            public void Shoot() { }
        }
        public class RandomAudioPlayer
        {
            public void Play() { }
        }

        public class LevelDesignAssistance : MonoBehaviour
        //Alt names: LevelDesigner, LevelDesignTools, LevelDesignUtility
        {
            //Editor based class to assist in designing the level

        }

        public class StudentUtility : ScriptableObject
        {
            //Alternative names:
            //StudentBuilder, StudentManager

            //Class that manages, handles creation and randomization of students

            [SerializeField] Classroom classroom;
            [SerializeField] GameObject studentPrefab;
            Student[] students;
            public int rows = 2, columns = 4;
            public Rect posNpad = new Rect(0, 0, 20f, 20f);     //Position (x,y) and Padding (widht, height)


            public static void GenerateStudents()
            {
                //Create a new empty classroom game object on the root node
                var newClassroom = new GameObject("Classroom");
                newClassroom.transform.SetParent(null);

                //Create students from prefabs and child them to the new classroom

                //Set the student positions relative to the starting point

            }
        }

        public class Student
        {
            StudentAppearance appearance;

            void Awake()
            {
                studentManager = GameObject.FindObjectOfType<StudentManager>();
            }
        }

        public class GameManager
        {
            StudentManager studentManager;



        }

        public enum StudentType
        {
            Athletic,
            Skater,
            Lovers,
            HallMonitor,
            ChatterBox
        }

        public enum PassDirection
        {
            UP,
            DOWN,
            LEFT,
            RIGHT
        }

        struct StudentAppearance
        {
            // Sprite desk;
            // Sprite head;
            // Sprite hair;
            // Sprite 
        }

        public class Student
        {
            public PassDirection[] passDirections = new PassDirection[4];   //U, D, L, R
            public StudentType studentType;

        }


        public class StudentManager : MonoBehaviour
        {
            //Class that holds all the students
            //Build students?
            //Singleton?

            public Student[] students;

            void Awake()
            {
                students = GameObject.FindObjectsOfType(typeof(Student)) as Student[];
            }
        }


        public class InputController
        {
            public bool left;
            public bool right;
            public bool up;
            public bool down;
            public bool next;
            public bool prev;
        }
    }
}