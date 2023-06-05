using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] Transform SpawnPoint;
    [SerializeField] float spawnTime;
    [SerializeField] GameObject enemyPrefab;

	private void OnEnable()
	{
		StartCoroutine(SpawnRoutine());
	}

	private void OnDisable()
	{
		StopAllCoroutines();
	}

	IEnumerator SpawnRoutine()
	{ 
		while (true) 
		{
			yield return new WaitForSeconds(spawnTime);
			Instantiate(enemyPrefab, SpawnPoint.position, SpawnPoint.rotation);
		}
	}
}
