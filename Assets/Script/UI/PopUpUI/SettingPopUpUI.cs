using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingPopUpUI : PopUpUI
{
	protected override void Awake()
	{
		base.Awake();

		buttons["ContinueButton"].onClick.AddListener(() => { Debug.Log("Continue"); });
		buttons["SettingButton"].onClick.AddListener(() => { GameManager.UI.ShowPopUpUI<PopUpUI>("UI/SettingPopUpUI"); });
		buttons["ExitButton"].onClick.AddListener(() => { Debug.Log("Exit"); });
	}
}
