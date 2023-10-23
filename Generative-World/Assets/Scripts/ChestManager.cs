using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestManager : MonoBehaviour
{
    public GameObject[] chestsSpawned;
    public GameObject chestObject;
    public int poolMin = 2;
    public int poolMax = 6;
    public int currChest = 0;

    // Start is called before the first frame update
    void Start()
    {
        chestsSpawned = new GameObject[poolMax];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstantiateChest(Vector3 pos, Quaternion rot)
    {
        if (chestsSpawned[currChest] != null)
        {
            chestsSpawned[currChest].gameObject.SetActive(false);
            chestsSpawned[currChest].gameObject.transform.position = pos;
            chestsSpawned[currChest].gameObject.transform.rotation = rot;
            chestsSpawned[currChest].gameObject.SetActive(true);
        } else
        {
            GameObject chest = Instantiate(chestObject, pos, rot, transform);
            chestsSpawned[currChest] = chest;
        }
        currChest += 1;
        if (currChest == chestsSpawned.Length)
        {
            currChest = 0;
        }
    }
}
