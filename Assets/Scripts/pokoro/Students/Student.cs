using System;
using UnityEngine;
using UnityEngine.Assertions;

namespace pokoro
{
    public enum PassDirection
    {
        FORWARD,
        LEFT,
        RIGHT,
        BACKWARD
    }

    [System.Serializable]
    public struct CanPassDirection
    {
        public bool forward;
        public bool backward;
        public bool left;
        public bool right;
    }

    public interface IStudent
    {
        // [SerializeField] PassDirection[] canPassDirection = new PassDirection[4];
        // [SerializeField] CanPass canPass;

        void SetAppearance();

        //Set arrows based on position
        void AutoSetArrows();

        Student PassNote(PassDirection passDirection);
        void ReceiveNote(Student student);

    }

    //Normal student that can be derived by other student types
    public class Student : MonoBehaviour, IStudent
    {
        //public is only temp so that it shows up in the inspector
        public CanPassDirection canPass;
        public StudentAppearance appearance { get; set; }

        public Classroom classroom; //A student will ALWAYS be in (childed to) a classroom
        public Animator anim;
        public AudioManager audio; //ie. Random audio source, maybe singleton audio, maybe scriptable object

        void Start()
        {
            classroom = GetComponentInParent<Classroom>();
            Assert.IsNotNull(classroom, "Student not attached to any classroom!");
            anim = GetComponent<Animator>();
            audio = FindObjectOfType<AudioManager>();
        }

        void OnDrawGizmos()
        {

        }
        //---------------------------------------------------------
        public void AutoSetArrows()
        {
            //Check where the students are
            //Check if there are any students in 
            throw new NotImplementedException();
        }

        public virtual Student PassNote(PassDirection passDirection)
        {
            //Get the direction to pass the note
            //Find the 

            //If receiver found
            //Animate the student based on the direction
            //Play sounds
            //Etc
            //Return student

            throw new NotImplementedException();
        }

        public virtual void ReceiveNote(Student student)
        {
            //Calculate the direction based on the position of the student

            throw new NotImplementedException();
        }

        public void SetAppearance()
        {
            throw new NotImplementedException();
        }
    }
}