using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(spawn());
        }
    }

    private IEnumerator spawn()
    {
        yield return new WaitForSeconds(0.1f);
        CoinSpanwer._CoinSpanwer.spawn();
    }
}
