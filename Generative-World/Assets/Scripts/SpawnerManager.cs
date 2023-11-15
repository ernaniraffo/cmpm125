using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    public GameObject spawnerObject;
    public int spawnerPoolMax = 5;
    public List<GameObject> spawnerPool;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < spawnerPoolMax; i += 1)
        {
            float x = transform.position.x;
            float y = transform.position.y;
            float z = transform.position.z;
            GameObject spawner = Instantiate(spawnerObject, transform);
            spawner.transform.position = new Vector3(x, y, z + (i * 20));
            spawnerPool.Add(spawner);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
