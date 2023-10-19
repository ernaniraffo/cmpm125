using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject SphereParent;

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
		Destroy(this.gameObject);

		float x = transform.position.x;
		float y = 0.75f;
		float z = transform.position.z;
		Instantiate(SphereParent, new Vector3(x, y, z), new Quaternion());
	}
}
