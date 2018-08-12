using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour {

    public ObjectPooler coinPool;

    public float distanceBetweenCoins;

    private float random;
    private float randomRounded;

    public void SpawnCoins(Vector3 startPosition)
    {
        random = Random.Range(1f, 3f);
        randomRounded = Mathf.Round(random);

        GameObject coin1 = coinPool.GetPooledObject();
        coin1.transform.position = startPosition;
        coin1.SetActive(true);

        GameObject coin2 = coinPool.GetPooledObject();
        coin2.transform.position = new Vector3(startPosition.x - distanceBetweenCoins, startPosition.y, startPosition.z);
        coin2.SetActive(true);

        GameObject coin3 = coinPool.GetPooledObject();
        coin3.transform.position = new Vector3(startPosition.x + distanceBetweenCoins, startPosition.y, startPosition.z);
        coin3.SetActive(true);

        coin1.SetActive(false);
        coin2.SetActive(false);
        coin3.SetActive(false);

        if (randomRounded == 1f)
        {
            coin1.SetActive(true);
        }
        else if (randomRounded == 2f) 
        {
            coin1.SetActive(true);
            coin2.SetActive(true);
        }
        else if (randomRounded == 3f)
        {
            coin1.SetActive(true);
            coin2.SetActive(true);
            coin3.SetActive(true);
        }

    }

}
