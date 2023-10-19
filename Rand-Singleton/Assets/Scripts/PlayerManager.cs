using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    private static PlayerManager _instance;
    public static PlayerManager Instance { get { return _instance; } }

    public GameObject player;
    public GameObject CoinManager;
    public int coins = 0;

	private void Awake()
	{
		if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
        } else
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
        
    }
}
