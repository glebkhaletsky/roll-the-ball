using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    public CoinGenerate CoinGenerator;
    public Coin ClosestCoin;
    Transform _target;
    public GameObject Arrow;
    private void Update()
    {
        ClosestCoin = CoinGenerator.GetClosestCoin(transform.position);
        
        if (ClosestCoin != null)
        {
            Debug.DrawLine(transform.position, ClosestCoin.transform.position);
            _target = ClosestCoin.transform;
            Vector3 toTarget = _target.position - transform.position;
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(toTarget), 8f * Time.deltaTime);
        }
        else
        {
            Arrow.SetActive(false);
        }
        
    }
}
