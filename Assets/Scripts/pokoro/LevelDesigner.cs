using UnityEngine;

namespace pokoro
{
public class LevelDesigner : MonoBehaviour 
{
	public float one;
	public bool two;
	public int three;

	/* Need references to:
	- student prefab
	- different student skins ie. hair, arms, shirt?
	- 
	*/
	[SerializeField] GameObject studentPrefab;

	[SerializeField] SpriteArray desks;
	[SerializeField] SpriteArray chairs;
	[SerializeField] SpriteArray hairs;
	[SerializeField] SpriteArray torsos;
	[SerializeField] SpriteArray leftArms;
	[SerializeField] SpriteArray rightArms;



	public void Update()
	{

	}

}

}