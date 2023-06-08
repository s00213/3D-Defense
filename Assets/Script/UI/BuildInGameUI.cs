using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildInGameUI : InGameUI
{
    public TowerPlace towerPlace;

    protected override void Awake()
    {
        base.Awake();

		buttons["BlockerButton"].onClick.AddListener(() => { GameManager.UI.CloseInGameUI(this); });
        buttons["ArchorButton"].onClick.AddListener(() => { BuilldArchorTower(); });
		buttons["CanonButton"].onClick.AddListener(() => { BuilldCanonTower(); });
	}

	private void BuilldCanonTower()
	{
		TowerData canonTowerData = GameManager.Resource.Load<TowerData>("Data/CanonTowerData");
		towerPlace.BuildTower(canonTowerData);
		GameManager.UI.CloseInGameUI(this);
	}

	private void BuilldArchorTower()
	{
		TowerData archortowerData = GameManager.Resource.Load<TowerData>("Data/ArchorTowerData");
		towerPlace.BuildTower(archortowerData);
		GameManager.UI.CloseInGameUI(this);
	}
}
