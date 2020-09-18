using UnityEngine.Networking;
using UnityEngine;

public class teleport : NetworkBehaviour
{
	public enum Type
	{
		Shop = 0,
		Hint = 1,
		Gift = 2,
		Warp = 3,
		Game = 4,
		Pay = 5,
		Secret = 6,
		medicien = 7,
		payme = 8,
		payme2 = 9,
	}

	public enum Direction
	{
		down = 0,
		up = 1,
		left = 2,
		right = 3,
	}

	public bool enter;
	public bool exit;
	public string text;
	public char[] write;
	public Sprite actor;
	public string item1;
	public string item2;
	public string item3;
	public GameObject zext;
	public Type type;
	public Direction ex;
}
