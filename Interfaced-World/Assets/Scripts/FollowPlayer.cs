using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = WorldSingleton.main.player.gameObject.transform.position;

        float x = playerPos.x;
        float y = playerPos.y + 1;
        float z = playerPos.z - 5;

        transform.position = new Vector3(x, y, z);
    }
}
