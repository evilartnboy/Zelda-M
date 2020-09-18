using UnityEngine.Networking;

public class Item : NetworkBehaviour
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

	public int pay;
	public bool cansowrd;
	public bool woodsword;
	public bool wsword;
	public bool msword;
	public bool canitem;
	public bool canlamp;
	public bool rlamp;
	public bool boomerang;
	public bool mboomerang;
	public bool bow;
	public bool hasarrow;
	public bool silverarrow;
	public bool canflute;
	public bool haswater;
	public bool rod;
	public bool hasfood;
	public bool giveheart;
	public bool map;
	public bool bigsheild;
	public int givekey;
	public int givebomb;
	public bool letter;
	public bool heartconainer;
	public bool powerbracelet;
	public bool stepladder;
	public bool mkey;
	public bool mbook;
	public bool raft;
	public bool bluering;
	public bool redring;
	public bool bombup;
	public bool bombup2;
	public bool fullwater;
	public bool noanimation;
	public bool triforce;
	public bool north;
	public bool mid;
	public bool south;
	public bool west;
	public Dun dun;
}
