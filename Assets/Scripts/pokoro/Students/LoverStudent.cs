using System;
using UnityEngine;

namespace pokoro
{
	public class LoverStudent : Student
	{
		[Tooltip("This student's lover")]
		public LoverStudent partner;    //Must also be another lover student
		
		public override Student PassNote(PassDirection passDirection)
		{
			//Just passes the note as normal because the only way this student
			//can receive a note is via the partner.
			//The student will be 'magically' set active
			return base.PassNote(passDirection);
		}
		
		public override void ReceiveNote(Student student)
		{
			//Upon receiving note, will auto teleport note to partner
			
			throw new NotImplementedException();
		}
		
	}
}