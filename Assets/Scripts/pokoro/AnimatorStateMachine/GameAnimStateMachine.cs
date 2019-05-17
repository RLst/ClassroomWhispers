using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DTAnimatorStateMachine;

namespace pokoro
{
	[RequireComponent(typeof(Animator))]
	public class GameAnimStateMachine : MonoBehaviour
	{
		Animator gameStateMachineController; 

		void Awake()
		{
			//Setup state machine
			gameStateMachineController = GetComponent<Animator>();
			this.ConfigureAllStateBehaviours(gameStateMachineController);
		}

		void Update()
		{
			if (Input.GetKey(KeyCode.Alpha1)) GoToStateOne();
			if (Input.GetKey(KeyCode.Alpha2)) GoToStateTwo();
		}

		public void GoToStateOne()
		{
			gameStateMachineController.SetTrigger("StateOne");
		} 
		public void GoToStateTwo()
		{
			gameStateMachineController.SetTrigger("StateTwo");
		} 
	}
}