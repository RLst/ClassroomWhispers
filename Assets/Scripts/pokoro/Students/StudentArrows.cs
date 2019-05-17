using System;
using UnityEngine;

namespace pokoro
{
	public class StudentArrows : MonoBehaviour
	{
		Student student;
		
		GameObject[] arrows = new GameObject[4];

		[SerializeField] float minOffset = 0.7f;
		[SerializeField] float maxOffset = 1.0f;
		[SerializeField] float pulseTime = 1.4f;
		[SerializeField] float animationTime = 0.0f;
		[SerializeField] float direction = 1.0f;
		[SerializeField] float smallScale = 0.8f;
		[SerializeField] float largeScale = 1.0f;


		bool hasPlayerFocus = false;

		void Awake()
		{
			student = GetComponent<Student>();
		}

		void OnEnable()
		{


		}

		public void SetArrows()
		{
			for (int i = 0; i < student.connectedClassmates.Length; i++)
			{

				// if (student.connectedClassmates[i].direction)
				// student.connectedClassmates[i].direction
			}
			throw new NotImplementedException();

		}
		public void EnablePulse()
		{

		}

		public void DisablePulse()
		{

		}

	}
}