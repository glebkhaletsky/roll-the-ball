using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(110  * Time.deltaTime,0, 0);
        transform.localPosition = new Vector3(transform.position.x, Mathf.Sin(Time.time * 5f) * 0.1f, transform.position.z);

    }
}
