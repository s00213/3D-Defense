using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBall : MonoBehaviour
{
	[SerializeField] float speed;
	[SerializeField] float range;

	private EnemyController enemy;


	//private Towerdata data;
	private int damage;
	private Vector3 targetPoint;

	public void SetTarget(EnemyController enemy)
	{
		this.enemy = enemy;
		StartCoroutine(ArrowRoutine());
	}

	public void SetDamage(int damage)
	{
		this.damage = damage;
	}



	IEnumerator ArrowRoutine()
	{
		while (true)
		{
			//if (enemy == null)
			//{
			//    GameManager.Resource.Destroy(gameObject);
			//    yield break;
			//}

			if (enemy != null)
				targetPoint = enemy.transform.position;

			//Vector3 targetPoint = enemy.transform.position;

			//Vector3 vector = enemy.transform.position - transform.position;
			//Vector3 dir = vector.normalized;

			//transform.Translate(dir * speed * Time.deltaTime, Space.World);
			// or

			transform.LookAt(enemy.transform.position);
			transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);


			if (Vector3.Distance(enemy.transform.position, transform.position) < 0.1f)
			{
				Explosion();
				GameManager.Resource.Destroy(gameObject);
				yield break;
			}

			yield return null;
		}
	}

	public void Explosion()
	{
		Collider[] colllider = Physics.OverlapSphere(transform.position, range, LayerMask.GetMask("Enemy"));
		foreach (Collider collider in colllider) 
		{
			EnemyController enemy = collider.GetComponent<EnemyController>();
			enemy?.TakeHit(damage);

			//Rigidbody rb = collider.GetComponent<Rigidbody>();
			//rb?.AddExplosionForce() -> 사용할 수 있음
		}
	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position, range);
	}
}
