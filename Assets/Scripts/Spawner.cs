using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float boundaries = 2.55f;
    public GameObject bombPrefab;
    void Start()
    {
        StartCoroutine(bombSpawner());
    }
    IEnumerator bombSpawner()
    {
        yield return new WaitForSeconds(Random.Range(0.2f, 1f));
        Instantiate(
            bombPrefab, 
            new Vector2(Random.Range(-boundaries, boundaries), transform.position.y),
            Quaternion.identity
            );
        StartCoroutine(bombSpawner());
    }
}
