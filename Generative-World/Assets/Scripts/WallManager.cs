using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallManager : MonoBehaviour
{
    public GameObject wallObject;
    public GameObject spawnedWall;

    // Start is called before the first frame update
    void Start()
    {
        spawnedWall = Instantiate(wallObject, transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
