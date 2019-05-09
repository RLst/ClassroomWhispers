using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace pokoro
{
	public enum eStudentType
	{
		Normal,
		Athletic,
		Skater,
		Lovers,
		HallMonitor,
		Twins,
		Chatterbox

	}

	[CreateAssetMenu(menuName = "Tests/StudentType")]
	public class StudentType : ScriptableObject
	{
		public float testfloat = 5f;
	}
}