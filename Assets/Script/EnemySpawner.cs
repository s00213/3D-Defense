using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] Transform SpawnPoint; // 어디에 몬스터를 만들것인지
    [SerializeField] float spawnTime; // 얼마나 자주 만들것인지
    [SerializeField] GameObject enemyPrefab; // 어떤 몬스터를 만들것인지

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
