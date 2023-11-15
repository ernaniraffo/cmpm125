using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBox : MonoBehaviour
{
    private int value = 1;
    private Collider boxCollider;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider = gameObject.GetComponent<Collider>();
        boxCollider.isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        WorldSingleton.main.coinManager.ChangeCoinAmount(value);
    }

    private void OnTriggerExit(Collider other)
    {
        boxCollider.isTrigger = false;
    }
}
