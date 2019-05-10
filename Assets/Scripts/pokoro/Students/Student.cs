using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace pokoro
{
	public enum PassDirection : byte
	{
		Up,
		Right,
		Down,
		Left,
		Count,
	}

	[System.Serializable]
	//A class mate is a student that you are connected to
	public struct ConnectedClassmate
	{
		public PassDirection direction;
		public Student student;
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
	[RequireComponent(typeof(Classroom))]
	public class Student : MonoBehaviour, IStudent
	{
		public event Action OnClassmatesConnected = delegate {};
	
		//public is only temp so that it shows up in the inspector
		public StudentAppearance appearance { get; set; }
		public ArrowIndicators arrows;
		public Classroom classroom; //A student will ALWAYS be in (childed to) a classroom
		public Animator anim;
		public AudioManager audio; //ie. Random audio source, maybe singleton audio, maybe scriptable object


		//Accessible and modifiable by the designer
		// [SerializeField] PassDirectionStudentDictionary connectedClassmates = PassDirectionStudentDictionary.New<PassDirectionStudentDictionary>();
				
		
		//------------- OLD --------------------
		public ConnectedClassmate[] connectedClassmatesOLD;        //Viewable on inspected. Workaround since inspector can't display dictionaries
		//Internal. Should transfer over from connectedClassmates
		protected Dictionary<PassDirection, Student> m_connectedClassmates = new Dictionary<PassDirection, Student>();
		//---------------------------------------	
		//Dictionary<Pass Direction, SortedList of Students that are in this direction with corresponding distance values>
		private Dictionary<PassDirection, SortedList<float, Student>> directionAndDistanceSortedClassmates;
		

		void Awake()
		{
			classroom = GetComponentInParent<Classroom>();
			Assert.IsNotNull(classroom, "Student not attached to any classroom!");
			anim = GetComponent<Animator>();
			audio = FindObjectOfType<AudioManager>();
		}

		void Start()
		{
			// //Transfer connected classmates array over to dictionary
			// for (int i = 0; i < connectedClassmates.dictionary.Count; i++)
			// {
			// 	connectedClassmates.dictionary.Add(connectedClassmates)
			// 	connectedClassmates.dictionary.Add(connectedClassmates.dictionary[i].direction, connectedClassmates.dictionary[i].student);
			// }
			
			//Maybe auto connect the classmates?
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

		//Auto links the connected classmates (probably needs a different one for each type of student)
		public virtual void AutoConnectClassmates()
		{
			SortClassmatesByDirectionAndDistance();
			ConnectClassmatesNORMAL();  //connect classmates normally
		}

		//Connects the classmates NORMALLY ie. no skips
		private void ConnectClassmatesNORMAL()
		{
			//For normal students, just get the first student.transform reference
			//If this was athletic, a value of 1 would skip once
			int normalClassmateSkips = 0;

			foreach (var cm in connectedClassmates.dictionary)
			{
				cm.Key
			}

			// for (int i = 0; i < (int)PassDirection.Count; i++)
			// {
			// 	//Get direction of the connection
			// 	connectedClassmates[i].direction = (PassDirection)i;

			// 	//Get connected student of this direction
			// 	connectedClassmates[i].student = directionAndDistanceSortedClassmates[(PassDirection)i][normalClassmateSkips];
			// }
		}

		//Builds a pass direction dictionary of classmates sorted by distance
		protected void SortClassmatesByDirectionAndDistance()   //TODO Not sure if this should be protected
		{
			//Allocate the mega classmate array of arrays
			directionAndDistanceSortedClassmates = new Dictionary<PassDirection, SortedList<float, Student>>((int)PassDirection.Count);

			for (int i = 0; i < (int)PassDirection.Count; i++)
			{
				//Create a new pass direction slot
				directionAndDistanceSortedClassmates.Add((PassDirection)i, new SortedList<float, Student>());

				//Reset the manhattan distance
				float shortestManHatDistance = Mathf.Infinity;

				//Go through all classmates...
				foreach (var otherStudent in classroom.students)
				{

					//Filter classmates that aren't in the correct direction
					if (CheckStudentInCorrectDirection(otherStudent, (PassDirection)i))     //i: 0 = UP, 1 = RIGHT, 2 = DOWN, 3 = LEFT
					{
						//Find the student with the shortest manhattan distance
						Vector2 squareLengths;
						squareLengths.x = Mathf.Abs(otherStudent.transform.position.x) - Mathf.Abs(transform.position.x);
						squareLengths.y = Mathf.Abs(otherStudent.transform.position.y) - Mathf.Abs(transform.position.y);
						float manHatDistance = squareLengths.x + squareLengths.y;

						//Save new distance if it's shorter
						if (manHatDistance < shortestManHatDistance)
						{
							shortestManHatDistance = manHatDistance;

							//Record and auto sort current closest student found
							directionAndDistanceSortedClassmates[(PassDirection)i].Add(shortestManHatDistance, otherStudent);
						}
					}
				}
			}
		}

		//Checks if the a student is in the correct direction
		public bool CheckStudentInCorrectDirection(Student other, PassDirection passDirection)
		{
			switch (passDirection)
			{
				//These must match the declaration order of the PassDirection enums!
				case PassDirection.Up:
					return other.transform.position.y > transform.position.y;
				case PassDirection.Right:
					return other.transform.position.x > transform.position.x;
				case PassDirection.Down:
					return other.transform.position.y < transform.position.y;
				case PassDirection.Left:
					return other.transform.position.x < transform.position.x;
				default:
					Debug.LogError("Invalid PassDirection!");
					return false;
			}
		}

		public virtual Student PassNote(PassDirection passDirection)
		{
			//Is there a student available?
			var connectedClassmate = m_connectedClassmates[passDirection];
			if (connectedClassmate != null)
			{
				//If so then:
				//Transfer note
				connectedClassmate.ReceiveNote(this);

				//Play animation/sounds etc
				PlayPassAnimation();
				PlayPassSoundFX();

				//Return the student passed to
				return connectedClassmate;
			}
			return null;
		}

		private void PlayPassSoundFX()
		{
			Debug.Log("Passing sound");
			throw new NotImplementedException();
		}

		private void PlayPassAnimation()
		{
			Debug.Log("Passing animation");
			throw new NotImplementedException();
		}

		public virtual void ReceiveNote(Student student)
		{
			//Calculate the direction based on the position of the student



			//Play receiving stuff

			throw new NotImplementedException();
		}

		public void SetAppearance()
		{
			throw new NotImplementedException();
		}
	}
}

	// public struct CanPassDirection
	// {
	// 	public bool Up;
	// 	public bool Down;
	// 	public bool Left;
	// 	public bool Rigth;
	// 	// public bool UpRight;
	// 	// public bool DownRight;
	// 	// public bool UpLeft;
	// 	// public bool DownLeft;
	// }

				//Setup connected classmates array
			// m_connectedClassmates = new ConnectedClassmate[(int)PassDirection.Count];
			// for (int i = 0; i < (int)PassDirection.Count; i++)
			// {
			// 	m_connectedClassmates[i].direction = (PassDirection)i;
			// 	m_connectedClassmates[i].student = null;
			// }