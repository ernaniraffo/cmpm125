using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
	private static CoinManager _instance;
	public static CoinManager Instance { get { return _instance; } }

	public GameObject CoinObject;
	public PlayerManager player_manager;
	public int coins = 50;

	private void Awake()
	{
		if (_instance != null && _instance != this)
		{
			Destroy(gameObject);
		}
		else
		{
			_instance = this;
		}
	}

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player_manager)
		{
			coins -= 1;
		}
    }
}
