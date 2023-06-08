using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArchorTower : Tower
{
	public void Awake()
	{
		data = GameManager.Resource.Load<TowerData>("Data/ArchorData");		
	}
}
