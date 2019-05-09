using System.Collections.Generic;
using UnityEngine;

namespace pokoro.Architecture
{
    //Class that manages the gameplay ie. Input, switching game states and screens
    public class GameplayManager
    {
        Classroom classroom;
    }

    public class GameplayInput
    {
        //Accessors
        public bool left { get; }
        public bool right { get; }
        public bool up { get; }
        public bool down { get; }
        public bool next { get; }
        public bool prev { get; }
    }

    public class Classroom : MonoBehaviour
    {
        
    }

    //Controls the student
    public abstract class Student
    {
        StudentAppearance appearance;		//Each student has a certain look (probably randomized)
        Classroom classroom;				//Each student in (childed to) a classroom
        public abstract void PassNote();        //Each student type has a different way of passing notes
    }

	// Tool to help build students ie. their appearance?
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

    public class LevelDesigner
    {
        //Editor based class to assist in designing the level
        Classroom classroom;

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
    }
}
