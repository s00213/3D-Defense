using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public TowerData data;

    public List<EnemyController> enemyList;


	protected virtual void Awake()
	{
		enemyList = new List<EnemyController>();	
	}

	public void AddEnemy(EnemyController enemy)
	{ 
	
	}

	public void RemoveEnemy(EnemyController enemy)
	{ 
	
	}
}
