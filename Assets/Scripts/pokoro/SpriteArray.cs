using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace pokoro
{
public class SpriteArray : MonoBehaviour 
{
	[SerializeField] Sprite[] sprites;

	public Sprite GetRandom()
	{
		//Return a random sprite if they're avaialbe
		if (sprites.Length > 0)
		{
			return sprites[Random.Range(0, sprites.Length - 1)];
		}
		//Otherwise don't return anything
		return null;
	}

	public Sprite Get(int index)
	{
		return sprites[index];
	}

}
}