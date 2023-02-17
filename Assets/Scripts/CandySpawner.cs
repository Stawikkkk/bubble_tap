using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{


    public GameObject[] Candies;

    [SerializeField]
    float maxX;

    [SerializeField]
    float spawnInterval;

    public static CandySpawner instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }


    void Start()
    {
        //SpawnCandy();

        StartSpawnigCandies();
    }

   
    void Update()
    {
        
    }

    void SpawnCandy()
    {
        int random = Random.Range(0, Candies.Length);

        float randomPos = Random.Range(-maxX, maxX);

        Vector3 randomPoss = new Vector3(randomPos, transform.position.y, transform.position.z);

        Instantiate(Candies[random], randomPoss, transform.rotation);
    }

    IEnumerator SpawnCandies()
    {
        yield return new WaitForSeconds(2f);

        while (true)
        {
            SpawnCandy();

            yield return new WaitForSeconds(spawnInterval);
        }
    }

    public void StartSpawnigCandies()
    {
        StartCoroutine(SpawnCandies());

    }

    public void StopSpawnigCandies()
    {
        StopCoroutine(SpawnCandies());

    }
}
