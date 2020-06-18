using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{

	void Start()
	{
		int[] array = { 10, 20, 30, 40, 50 };

		Debug.Log("通常の順番");
		for (int i = 0; i < array.Length; i++)
		{
			Debug.Log(array[i]);
		}

		Debug.Log("逆の順番");
        for (int i = 4; i > -1; i--)
        {
			Debug.Log(array[i]);
		}
	}

	void Update() {

	}
}