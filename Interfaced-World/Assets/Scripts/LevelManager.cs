using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int currentLevel = 0;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        CheckPlayerPos();
    }

    public void SwitchLevel()
    {
        WorldSingleton.main.SwitchScene();
        WorldSingleton.main.player.transform.position = new Vector3(0, 1, 0);
    }

    public void SwitchLevelOnClick(int level)
    {
        currentLevel = level - 1;
        SwitchLevel();
    }

    public void CheckPlayerPos()
    {
        if (WorldSingleton.main.player.transform.position.y < GameObject.Find("LevelFloor").transform.position.y)
        {
            WorldSingleton.main.player.PlayerDeath();
        }
    }

    public void Reset()
    {
        currentLevel = 0;
    }


}

