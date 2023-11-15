using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://stackoverflow.com/questions/62093586/having-a-camera-follow-a-ball-in-unity-without-having-the-camera-roll

public class FollowCam : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = GameSingleton.main.player.gameObject.transform.position;

        float x = playerPos.x;
        float y = playerPos.y + 2;
        float z = playerPos.z - 4;

        transform.position = new Vector3(x, y, z);
    }
}
