using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InfoSceneUI : SceneUI
{
	//public TMP_Text heartText;

	protected override void Awake()
	{
		base.Awake();

		//heartText = texts["HeartText"];
		//heartText.text = 10.ToString();

		texts["HeartText"].text = "20";
		texts["CoinText"].text = "100";
	}
}
