using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingSceneUI : SceneUI
{
    protected override void Awake()
    {       
        base.Awake();

        buttons["InfoButton"].onClick.AddListener(() => { OpenInfoWindowUI(); });
        buttons["VolumeButton"].onClick.AddListener(() => { Debug.Log("Volum"); });
		buttons["SettingButton"].onClick.AddListener(() => { OpenPausePopUpUI(); });
	}

	public void OpenInfoWindowUI()
	{
		//GameManager.UI.ShowWindowUI<WindowUI>("UI/");
	}

	public void OpenPausePopUpUI()
	{
		GameManager.UI.ShowPopUpUI<PopUpUI>("UI/SettingPopUpUI");
	}
}
 
