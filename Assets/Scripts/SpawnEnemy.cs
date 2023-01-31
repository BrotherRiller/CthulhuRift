using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] float spawnRate;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait(30));
    }

    // Update is called once per frame

    IEnumerator Wait(int wait)
    {
        yield return new WaitForSeconds(wait);

        StartCoroutine(Spawn(30));
    }

    IEnumerator Spawn(int count) //Coroutine
    {
        int _count = 0;
        while (_count <= count)
        {
            yield return new WaitForSeconds(spawnRate);
            Instantiate(prefab, gameObject.transform.position, Quaternion.identity);
            _count++;
        }
    }
}
