using System.Collections;
using System.Collections.Generic;
using System.IO.Enumeration;
using UnityEngine;

[CreateAssetMenu (fileName = "TowerData", menuName = "Data/Tower")]
public class Towerdata : ScriptableObject
{
	[SerializeField] TowerInfo[] towers;
	public TowerInfo[] tower;

	[SerializeField]
	public class TowerInfo
	{
		public Tower lv1tower;
		public Tower lv2tower;
		public Tower lv3tower;
		public Tower lv4tower;

		public float buildTime;
		public int buildCost;
		public int sellCost;
	}
}
