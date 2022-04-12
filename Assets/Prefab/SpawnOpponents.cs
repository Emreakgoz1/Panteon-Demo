using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SpawnOpponents : MonoBehaviour
{
    public List<GameObject> opponents = new List<GameObject>();
    public List<Transform> spawnPoints = new List<Transform>();

    public static int playerCount;

    void Awake()
    {
        //Get players count as static
        playerCount = transform.childCount + 1;
    }
    void Start()
    {
        //Get spawn points to list
        for (int i = 0; i < transform.childCount; i++)
        {
            spawnPoints.Add(transform.GetChild(i));
        }

        //Randomized spawn points
        spawnPoints.OrderBy(i => Random.value).ToList();

        //Randomized opponents
        opponents.OrderBy(i => Random.value).ToList();

        //Positioning
        foreach (Transform spawnPoint in spawnPoints)
        {
            Instantiate(opponents[Random.Range(0, opponents.Count)], spawnPoint.position, Quaternion.identity);
        }
    }
}
