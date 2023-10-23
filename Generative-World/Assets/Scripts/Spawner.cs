using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	private int numChestsToSpawn = -1;
	private bool generated = false;

	// Start is called before the first frame update
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
		if (!generated)
		{

			if (numChestsToSpawn < 0) {
				int min = GameSingleton.main.chestManager.poolMin;
				int max = GameSingleton.main.chestManager.poolMax;
				numChestsToSpawn = Random.Range(min, max);
			}

			for (int i = 0; i < numChestsToSpawn; i += 1)
			{
				// position 
				Vector3 chestPos = Random.onUnitSphere;
				chestPos.z += Random.Range(3, 10) + (GameSingleton.main.levelManager.level * 20);
				chestPos.y = 0.3f;

				// rotation
				int yRot = Random.Range(90, 150);
				Quaternion randomRotation = Quaternion.Euler(0, yRot, 0);

				// spawn chest
				GameSingleton.main.chestManager.InstantiateChest(chestPos, randomRotation);

				// only perform OnTriggerEnter once
				generated = true;
			}

			// make one chest a trigger volume
			GameObject[] chestsSpawned = GameSingleton.main.chestManager.chestsSpawned;
			int maxChestIndex = GameSingleton.main.chestManager.currChest;
			int goldenChestIndex = Random.Range(0, maxChestIndex);
			GameObject goldenChest = chestsSpawned[goldenChestIndex];
			goldenChest.gameObject.GetComponent<Collider>().isTrigger = true;
		}
	}
}
