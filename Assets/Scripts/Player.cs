using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CoinGenerate CoinGenerator;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Coin>())
        {
            CoinGenerator.CollectCoin(other.GetComponent<Coin>());
        }
    }
}
