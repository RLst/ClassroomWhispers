using UnityEngine;

namespace pokoro
{
    // [CreateAssetMenu(fileName = "Classroom", menuName = "Managers/Classroom")]
    public class Classroom : MonoBehaviour
    {
        //// The global:: is temporary!!!
        //// public is temporary!!!
        public Student[] students;
        public Student activeStudent;  //Pointer to student that's holding the note
        // public Student lastStudent;  ??

        void Start()
        {
            students = GetComponentsInChildren<Student>();
        }
        //------------------------------------------------------

        //Since the classroom has direct references to students
        //might be better if this method is here
        public void RandomizeAllStudentAppearances()
        {
            Debug.Log("Randomizing Students!");
            foreach (var student in students)
            {
                student.appearance = StudentWardrobe.Instance.Randomize(student);
                //student.RandomizeAppearance();
            }
        }

        //----------Tests
        // public void PassNote(Vector2 direction) {}
        // //Pass note 
        // public void PassNote(PassDirection passDirection, int skips)
        // {
        //     //Get current student that has the note
        //     //Find the closest student
        //     //Determine if he/she is within the pass direction
        //         //Skip if necessary
        // }
        // //Pass note all the way to the end of the line
        // public void PassNoteEnd(PassDirection passDirection) {}
        
    }
}