using System;

namespace pokoro
{
	public class AthleticStudent : Student
	{
		//Amount of students this student can throw the letter over
		public uint skips = 1;

        public override Student PassNote(PassDirection passDirection)
		{
			//This student can pass the note over a student
			throw new NotImplementedException();
		}
		
		public override void ReceiveNote(Student student)
		{
			//Nothing special happens when this student receives a note
			base.ReceiveNote(student);
		}
	}
}