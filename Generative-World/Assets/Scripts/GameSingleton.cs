using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSingleton : MonoBehaviour
{
    private static GameSingleton _main;
	public static GameSingleton main { get { return _main; } }

    public WallManager wallManager { get; private set; }
    public ChestManager chestManager { get; private set; }
    public SpawnerManager spawnerManager { get; private set; }
    public LevelManager levelManager { get; private set; }
    public Player player { get; private set; }

	private void Awake()
	{
		if (_main != null && _main != this)
        {
            Destroy(this.gameObject);
        } else
        {
            _main = this;
        }

        wallManager = GetComponentInChildren<WallManager>();
        spawnerManager = GetComponentInChildren<SpawnerManager>();
        chestManager = GetComponentInChildren<ChestManager>();
        levelManager = GetComponentInChildren<LevelManager>();
        player = GetComponentInChildren<Player>();
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
