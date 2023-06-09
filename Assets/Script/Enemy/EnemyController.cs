using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyController : MonoBehaviour
{
	[SerializeField] int hp;
	public int HP { get { return hp; } private set { hp = value; OnchangedHP.Invoke(hp); } }
	public UnityEvent<int> OnchangedHP;
	public UnityEvent OnDied;




	public void TakeHit(int damage)
	{
		hp -= damage;
		OnchangedHP.Invoke(hp);

		if (HP <= 0)
		{ 
			
		}



	}
}
