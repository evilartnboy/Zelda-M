using UnityEngine;

public class Maze : MonoBehaviour
{
	public enum Di
	{
		up = 0,
		down = 1,
		left = 2,
		right = 3,
	}

	public Di direction;
	public GameObject up;
	public GameObject down;
	public GameObject left;
	public GameObject right;
	public bool mountian;
	public bool forest;
	public int correctpath;
}
