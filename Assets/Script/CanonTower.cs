using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonTower : Tower
{
	public void Awake()
	{
		data = GameManager.Resource.Load<TowerData>("Data/CannonTower");
	}


}
