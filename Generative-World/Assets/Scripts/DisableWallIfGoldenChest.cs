using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableWallIfGoldenChest : MonoBehaviour
{
    private GameObject wallToMove;

    // Start is called before the first frame update
    void Start()
    {
        wallToMove = GameSingleton.main.wallManager.spawnedWall;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered");
        Vector3 wallToMovePosition = wallToMove.gameObject.transform.position;

        float x = wallToMovePosition.x;
        float y = wallToMovePosition.y;
        float z = wallToMovePosition.z + 20;
        wallToMove.gameObject.transform.position = new Vector3(x, y, z);

        GameSingleton.main.levelManager.level += 1;
    }

    private void OnTriggerExit(Collider other)
    {
        gameObject.GetComponent<Collider>().isTrigger = false;
    }
}
