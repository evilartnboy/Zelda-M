using UnityEngine;

public class door : MonoBehaviour
{
	public enum Type
	{
		open = 0,
		locked = 1,
		trap = 2,
		bomb = 3,
	}

	public enum Di
	{
		up = 0,
		down = 1,
		right = 2,
		left = 3,
	}

	public enum Dun
	{
		one = 0,
		two = 1,
		three = 2,
		four = 3,
		five = 4,
		six = 5,
		seven = 6,
		eight = 7,
		nine = 8,
	}

	public Type type;
	public Di di;
	public Dun dun;
	public GameObject linkbuddy;
	public GameObject spawner;
	public bool triggered;
	public GameObject trigger;
}
