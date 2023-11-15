using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided with" + collision);
        if (collision.gameObject == WorldSingleton.main.player.gameObject)
        {
            Debug.Log("Hello");
            WorldSingleton.main.player.ChangeHealth(-(100f/3f));
        }
    }
}
