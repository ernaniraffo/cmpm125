using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldSingleton : MonoBehaviour
{
    private static WorldSingleton _main;
    public static WorldSingleton main { get { return _main; } }

    public Player player { get; private set; }
    public CoinManager coinManager { get; private set; }
    public MenuManager menuManager { get; private set; }
    public LevelManager levelManager { get; private set; }

    private void Awake()
    {
        if (_main != null && _main != this)
        {
            Destroy(gameObject);
        } else
        {
            _main = this;
        }

        DontDestroyOnLoad(gameObject);

        player = GetComponentInChildren<Player>();
        coinManager = GetComponentInChildren<CoinManager>();
        menuManager = GetComponentInChildren<MenuManager>();
        levelManager = GetComponentInChildren<LevelManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchScene()
    {
        SceneManager.LoadScene(++main.levelManager.currentLevel);
        main.menuManager.ShowMenu(false);
    }

    public void Restart()
    {
        main.player.Reset();
        main.coinManager.Reset();
        main.levelManager.Reset();
        if (main.levelManager.currentLevel != 0)
        {
            SceneManager.LoadScene(0);
        }
        main.menuManager.ShowMenu(true);
    }
}
