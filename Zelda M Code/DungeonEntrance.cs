using UnityEngine;

public class DungeonEntrance : MonoBehaviour
{
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

	public Dun dun;
	public bool entrance;
	public bool exit;
	public GameObject pair;
	public float exitposx;
	public float exitposy;
	public GameObject dung;
}
