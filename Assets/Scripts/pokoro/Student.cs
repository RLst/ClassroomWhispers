using System;
using UnityEngine;

namespace pokoro
{
	public enum PassDirection
	{
			FORWARD, 
		LEFT, 		RIGHT,
			BACKWARD
    }
    public abstract class Student : MonoBehaviour
    {
		[SerializeField] PassDirection[] passDirection = new PassDirection[4];

		void Start()
		{
			InitArrows();
		}

        public void InitArrows()
        {
            throw new NotImplementedException();
        }

		// void OnDrawGizmosSelected()
		// {
		// 	Gizmos.color = Color.green;

		// 	Gizmos.DrawIcon()

		// }

    }

    public class NormalStudent : Student
    {
		public string normal = "This is a normal student!";

		public void Start()
		{

		}
    }

    public class AthleticStudent : Student
    {
		public void Start()
		{
			Debug.Log("AthleticStudent.Start()");
		}
    }

	public class SkaterStudent : Student
	{

	}

	public class LoverStudent : Student
	{

	}

	public class HallMonitorStudent : Student
	{

	}

}
