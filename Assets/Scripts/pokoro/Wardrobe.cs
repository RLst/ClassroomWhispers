using UnityEngine;

namespace pokoro
{
	[CreateAssetMenu]
	public class StudentWardrobe : ScriptableObject
	{
		//Singleton
		public static StudentWardrobe Instance { get; private set; }

		[SerializeField] Sprite[] heads;
		[SerializeField] Sprite[] hairs;
		[SerializeField] Sprite[] leftArms;
		[SerializeField] Sprite[] rightArms;


		void Start()
		{
			//Singleton
			Instance = this;
		}

		//Pass in a student to randomize it's appearance?
		public StudentAppearance Randomize(Student student)
		{
			var appearance = student.GetComponent<StudentAppearance>();
			//-------NOT FINISHED---------
			appearance.hair = heads[0];
			appearance.head = hairs[0];
			appearance.leftArm = leftArms[0];
			appearance.rightArm = rightArms[0];
			return appearance;
		}
	}
}