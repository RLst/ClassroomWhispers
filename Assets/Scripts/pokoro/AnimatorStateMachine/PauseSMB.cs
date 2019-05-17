using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DTAnimatorStateMachine;

using System.Linq;

namespace pokoro
{
	public class PauseSMB : DTStateMachineBehaviour<GameAnimStateMachine>
	{
		public GameObject pauseMenu;

		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			//Find the pause menu
			pauseMenu = Resources.FindObjectsOfTypeAll<PauseUI>().FirstOrDefault().gameObject;
			// pauseMenu = (GameObject)Resources.FindObjectsOfTypeAll(typeof(PauseUI)).FirstOrDefault();

			if (pauseMenu != null)
				Debug.Log("Pause UI Found!");
			else
				Debug.LogError("Pause UI Not Found!!");

			pauseMenu.SetActive(true);
			// pauseMenu.gameObject.GetComponent<Canvas>().enabled = true;
		}

		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			// Debug.Log("TestGameStateOne Exited()");
			pauseMenu.SetActive(false);
			// pauseMenu.gameObject.GetComponent<Canvas>().enabled = false;
		}

		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			Debug.Log("PauseSMB.Update()");
			pauseMenu.SetActive(false);
		}

	}
}