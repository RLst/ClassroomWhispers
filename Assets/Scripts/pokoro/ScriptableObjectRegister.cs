using UnityEngine;

//This is required so that a project that uses scriptable objects will build properly
namespace pokoro
{
    public class ScriptableObjectRegister : MonoBehaviour
    {
        //Instructions: 
        //- Put this on any object in a scene (ideally something like a GameManager)
        //- Load in all critical scriptable objects
        public ScriptableObject[] scriptableObjects;

		void Awake()
		{
			//Try and auto load all SO's?
			var foundSOs = Resources.FindObjectsOfTypeAll(typeof(ScriptableObject)) as ScriptableObject[];
			// Debug.Log("Found " + foundSOs.Length + " Scriptable Objects");
			scriptableObjects = foundSOs;
		}
    }

}