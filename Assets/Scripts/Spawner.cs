using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float spawnInterval;
    [SerializeField] private GameObject zombiePrefab;
    private void Start()
    {
        StartCoroutine(SpawnFlow());
    }

    private IEnumerator SpawnFlow()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            var x = Random.Range(-5, 6);
            Instantiate(zombiePrefab,new Vector2(x,6), Quaternion.identity);
        }
    }
    
}
