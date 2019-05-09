using System;
using UnityEngine;

namespace pokoro
{
	public class SkaterStudent : Student
	{
        public override Student PassNote(PassDirection passDirection)
		{
			//This student passes the now all the way to the last student
			throw new NotImplementedException();
		}
		
		public override void ReceiveNote(Student student)
		{
			//Nothing special happens when this student receives a note
			base.ReceiveNote(student);
		}

	}
}