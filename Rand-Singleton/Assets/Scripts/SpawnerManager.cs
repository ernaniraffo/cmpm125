using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    public GameObject objectToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i += 1)
        {
			GameObject spawned = Instantiate(objectToSpawn, Random.insideUnitSphere, transform.rotation);
            spawned.transform.localScale = spawned.transform.localScale * 0.25f;
            spawned.gameObject.transform.SetParent(this.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
