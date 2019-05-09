using System;
using UnityEngine;
using System.Collections.Generic;

namespace pokoro
{
	//Each student will have one of these.
	//It only holds the current look of the student
	public class StudentAppearance : MonoBehaviour
	{
		[SerializeField] Sprite m_hair;
		public Sprite hair { get { return m_hair; } set { m_hair = value; } }
		[SerializeField] Sprite m_head;
		public Sprite head { get { return m_head; } set { m_head = value; } }
		[SerializeField] Sprite m_leftArm;
		public Sprite leftArm { get { return m_leftArm; } set { m_leftArm = value; } }
		[SerializeField] Sprite m_rightArm;
		public Sprite rightArm { get { return m_rightArm; } set { m_rightArm = value; } }

	}
}