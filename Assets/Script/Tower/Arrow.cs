using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class Arrow : MonoBehaviour
{

    [SerializeField] float speed;

    private EnemyController enemy;

    //private Towerdata data;
    private int damage;
    private Vector3 targetPoint;

    public void SetTarget(EnemyController enemy)
    { 
        this.enemy = enemy;
        StartCoroutine(ArrowRoutine());
    }

    public void SetDamage()
    { 
        
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
                Attack(enemy);
                GameManager.Resource.Destroy(gameObject);
            }

            yield return null;
        }
    }

	public void Attack(EnemyController enemy)
	{
		enemy.TakeHit(damage);
	}

}
