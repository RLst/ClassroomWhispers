using UnityEngine;

using DTAnimatorStateMachine;
using System.Linq;

namespace pokoro
{
	public class InGameSMB : DTStateMachineBehaviour<GameAnimStateMachine>
	{
		public GameObject inGameUI;
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			inGameUI = Resources.FindObjectsOfTypeAll<InGameUI>().FirstOrDefault().gameObject;

			// inGameUI = GameObject.FindGameObjectWithTag("InGameUI");
			if (inGameUI != null)
				Debug.Log("In Game UI Found!");
			else
				Debug.LogError("In Game UI Not Found!!");

			inGameUI.gameObject.SetActive(true);
			// inGameUI.enabled = true;
		}
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			// Debug.Log("TestGameStateTwo Updating");
			inGameUI.gameObject.SetActive(false);
			// inGameUI.enabled = false;
		}

		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			Debug.Log("InGameSMB.Update()");
		}
	}
}