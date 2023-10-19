using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyUpwards : MonoBehaviour
{
	public int height_limit = 5;

	// Start is called before the first frame update
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{
		float x = transform.position.x;
		float y = transform.position.y + 5 * Time.deltaTime;
		float z = transform.position.z;
		transform.position = new Vector3(x, y, z);
		if (transform.position.y >= height_limit)
		{
			Debug.Log("destroying object");
			Destroy(this.gameObject);
		}
	}
}
