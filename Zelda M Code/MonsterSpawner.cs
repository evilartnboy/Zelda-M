using UnityEngine.Networking;
using UnityEngine;

public class MonsterSpawner : NetworkBehaviour
{
	public bool spawnable;
	public GameObject[] monster;
	public bool completed;
	public GameObject giveitem;
	public bool bossspawn;
	public GameObject rpcmonster;
}
