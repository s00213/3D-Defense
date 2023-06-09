using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackRange : MonoBehaviour
{
	public Tower tower;
	public LayerMask enemyMask;

	//public UnityEvent<EnemyController> onInRangeEnemey;
	//public UnityEvent<EnemyController> 

	private void OnTriggerEnter(Collider other)
	{
		//if (enemyMask.IsContain(other.gameObject.layer))
		//{

		//}
	}

	private void OnTriggerExit(Collider other)
	{
		if (((1 << other.gameObject.layer) & enemyMask) != 0)
		{ 
		
		}
	}

}
