using System;
using UnityEngine;

namespace pokoro
{
	public enum PassDirection
	{
				FORWARD, 
		LEFT, 				RIGHT,
				BACKWARD
    }

	[System.Serializable]
	public struct CanPass {
		public bool forward;
		public bool backward;
		public bool left;
		public bool right;
	}

    public interface IStudent
    {
		

		// [SerializeField] PassDirection[] canPassDirection = new PassDirection[4];
		// [SerializeField] CanPass canPass;

		//Student methods
		void Pass();
		


		// void OnDrawGizmosSelected()
		// {
		// 	Gizmos.color = Color.green;
		// 	Gizmos.DrawIcon()
		// }
    }

	public abstract class Student : MonoBehaviour, IStudent
	{
		Classroom classroom;    //A student will always be in (childed to) a classroom

        public void Pass()
        {
            throw new NotImplementedException();
        }

        public virtual void Start()
		{
			classroom = GetComponentInParent<Classroom>();
		}

	}

    public class NormalStudent : Student
    {
		public string extraVariable = "Normal Student";

		public override void Start()
		{
			base.Start();
		}

    }

    // public class AthleticStudent : Student
    // {
	// 	public void Start()
	// 	{
	// 		Debug.Log("AthleticStudent.Start()");
	// 	}
    // }

	// public class SkaterStudent : Student
	// {

	// }

	// public class LoverStudent : Student
	// {

	// }

	// public class HallMonitorStudent : Student
	// {

	// }

}
