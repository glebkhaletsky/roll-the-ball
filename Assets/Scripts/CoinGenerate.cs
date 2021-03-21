using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinGenerate : MonoBehaviour
{
    public GameObject CoinPrefab;
    public List<Coin> AllCoins = new List<Coin>();
    public Text CoinText;
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            GameObject newCoin = Instantiate(CoinPrefab, new Vector3(Random.Range(-8, 8), 1f, Random.Range(-8, 8)), Quaternion.Euler(0, 0, -90));
            AllCoins.Add(newCoin.GetComponent<Coin>());
        }
        TextCoin();
    }

    public void CollectCoin(Coin coin)
    {
        AllCoins.Remove(coin);
        Destroy(coin.gameObject);
        TextCoin();
    }

    void TextCoin()
    {
        CoinText.text = "coins left: " + AllCoins.Count.ToString();
    }

    public Coin GetClosestCoin(Vector3 point)
    {
        float minDistance = Mathf.Infinity;
        Coin closestCoin = null;
        for (int i = 0; i < AllCoins.Count; i++)
        {
            float distance = Vector3.Distance(point,AllCoins[i].transform.position);
            if (distance < minDistance)
            {
                minDistance = distance;
                closestCoin = AllCoins[i];
            }
        }
        return closestCoin;
    }

}
