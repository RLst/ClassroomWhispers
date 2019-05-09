using UnityEngine;

namespace pokoro
{

public static class VectorExtensions 
{
	//Absolute Vector2
	public static Vector2 Abs<T>(this Vector2 vector)
	{
		return new Vector2(Mathf.Abs(vector.x), Mathf.Abs(vector.y));
	}

	//Absolute Vector3
	public static Vector3 Abs<T>(this Vector3 vector)
	{
		return new Vector3(Mathf.Abs(vector.x), Mathf.Abs(vector.y), Mathf.Abs(vector.z));
	}

	//Absolute Vector4
	public static Vector4 Abs<T>(this Vector4 vector)
	{
		return new Vector4(Mathf.Abs(vector.x), Mathf.Abs(vector.y), Mathf.Abs(vector.z), Mathf.Abs(vector.w));
	}
}

}