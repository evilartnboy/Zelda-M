using UnityEngine.Networking;
using UnityEngine;

public class MobAi : NetworkBehaviour
{
	public enum Type
	{
		Octorock = 0,
		BOctorock = 1,
		ArmosR = 2,
		ArmosW = 3,
		ArmosG = 4,
		Bubble = 5,
		Darknut = 6,
		BDarknut = 7,
		Gel = 8,
		Ghini = 9,
		FakeGhini = 10,
		Gibdo = 11,
		Goriya = 12,
		BGoriya = 13,
		Keese = 14,
		RKeese = 15,
		Lanmola = 16,
		BLanmola = 17,
		Leever = 18,
		BLeever = 19,
		LikeLike = 20,
		Lynel = 21,
		BLynel = 22,
		Moblin = 23,
		BMoblin = 24,
		Moldorm = 25,
		Peahat = 26,
		PolsVoice = 27,
		RiverZora = 28,
		Rock = 29,
		RopeNope = 30,
		Stalfos = 31,
		spiketrap = 32,
		Tektite = 33,
		BTektite = 34,
		Vire = 35,
		Wallmaster = 36,
		Wizzrobe = 37,
		BWizzrobe = 38,
		Zol = 39,
		Patara = 40,
		Patarababy = 41,
		Fairy = 42,
		Aquamentus = 43,
	}

	public int hp;
	public Type type;
	public Rigidbody2D rb2d;
	public float speed;
	public float moveHorizontal;
	public float moveVertical;
	public bool damaged;
	public Vector2 enemyfacing;
	public bool invulnerable;
	public bool cantattack;
	public bool cantmove;
	public int contact;
	public bool sleep;
	public bool candiagonal;
	public bool ghost;
	public bool charging;
	public bool jumper;
	public GameObject lastworm;
	public GameObject nextworm;
	public bool firstworm;
	public float wormdelay;
	public Vector2 movement;
	public GameObject parentpatara;
	public bool canchange;
	public int nokids;
	public bool stunnable;
	public bool cancontact;
	public bool boss;
	public GameObject[] drops;
	public GameObject bullet;
	public float atackt;
	public float divetime;
	public float t;
	public float f;
}
