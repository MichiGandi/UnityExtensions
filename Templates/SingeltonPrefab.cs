using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingeltonPrefab<T> : MonoBehaviour where T : SingeltonPrefab<T>
{
	static private T instance = null;
	static public T Instance
	{
		get
		{
			if (instance == null)
			{
				instance = Instantiate(Resources.Load($"SingeltonPrefab/{typeof(T).Name}") as GameObject).GetComponent<T>();
			}
			return instance;
		}
	}
}
