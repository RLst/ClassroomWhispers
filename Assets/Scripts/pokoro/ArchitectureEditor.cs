﻿using UnityEngine;
﻿using System.Collections.Generic;
using UnityEngine;

namespace pokoro.Architecture
{

    public class Architecture : MonoBehaviour {}

    public class LevelDesigner
    {
        //Editor based class to assist in designing the level
        StudentManager studentManager;

    public class StudentManager
        void Awake()
        {
            studentManager = GameObject.FindObjectOfType<StudentManager>();
        }
    }

    public class GameManager
    {
        //Class that handles all students
        StudentManager studentManager;


        
    }

    public class LevelDesigner
    public enum StudentType
    {
        //Editor based class to assist in designing the level
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

    public class 
    public class Student
    {
        public PassDirection[] passDirections = new PassDirection[4];    //U, D, L, R
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