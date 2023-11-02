using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinManager : MonoBehaviour
{
    [SerializeField] public TMP_Text coinCountLabel;
    [SerializeField] private int coinCountMax = 999;
    private int currentCointCount;

    // Start is called before the first frame update
    void Start()
    {
        currentCointCount = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeCoinAmount(int amount)
    {
        if (currentCointCount + amount <= coinCountMax)
        {
            currentCointCount += amount;
        }

        UpdateCoinLabel();
    }

    public void Reset()
    {
        currentCointCount = 0;
        UpdateCoinLabel();
    }

    private void UpdateCoinLabel()
    {
        coinCountLabel.text = currentCointCount.ToString();
    }
}
