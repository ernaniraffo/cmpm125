using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
	private Ray playerDetector;
	public GameObject rocket;
	public GameObject player;
	private GameObject spawnedObject;

	// Start is called before the first frame update
	void Start()
	{
		playerDetector = new Ray(transform.position, transform.up);
		player = GameObject.FindGameObjectsWithTag("Player")[0];
		Debug.Log(player);
	}

	// Update is called once per frame
	void Update()
	{
		Debug.DrawRay(transform.position, transform.up, Color.red);
		RaycastHit hit;
		if ((!spawnedObject) && Physics.Raycast(transform.position, transform.up, out hit))
		{
			Debug.DrawRay(transform.position, hit.normal, Color.blue);
			spawnedObject = Instantiate(rocket, transform.position, transform.rotation);

			Vector3 movementVec = player.transform.up;
			player.gameObject.GetComponent<Rigidbody>().MovePosition(movementVec * 0.05f * Time.deltaTime); ;
			Destroy(player, 5);
		}
	}
}
