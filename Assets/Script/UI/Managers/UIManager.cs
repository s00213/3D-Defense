using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIManager : MonoBehaviour
{
	private EventSystem eventSystem;

	private Canvas popUpCanvas;
	private Stack<PopUpUI> popUpStack;

	private Canvas windowCanvas;

	private Canvas inGameCanvas;

	private void Awake()
	{
		eventSystem = GameManager.Resource.Instantiate<EventSystem>("UI/EventSystem");
		eventSystem.transform.parent = transform;

		popUpCanvas = GameManager.Resource.Instantiate<Canvas>("UI/Canvas");
		popUpCanvas.gameObject.name = "PopUpCanvas";		
		popUpCanvas.sortingOrder = 100;
		popUpStack = new Stack<PopUpUI>();

		windowCanvas = GameManager.Resource.Instantiate<Canvas>("UI/Canvas");
		windowCanvas.gameObject.name = "WindowCanvas";
		windowCanvas.sortingOrder = 10;

		// gameSceneCanvas.sortingOrder = 1

		inGameCanvas = GameManager.Resource.Instantiate<Canvas>("UI/Canvas");
		inGameCanvas.gameObject.name = "InGameCanvas";
		inGameCanvas.sortingOrder = 0;
	}

	public T ShowPopUpUI<T>(T popUpUI) where T : PopUpUI
	{
		if (popUpStack.Count > 0)
		{
			PopUpUI prevUI = popUpStack.Peek();
			prevUI.gameObject.SetActive(false);
		}

		T ui = GameManager.Pool.GetUI(popUpUI);
		ui.transform.SetParent(popUpCanvas.transform, false);

		popUpStack.Push(ui);

		Time.timeScale = 0;

		return ui;
	}

	public T ShowPopUpUI<T>(string path) where T : PopUpUI
	{
		T ui = GameManager.Resource.Load<T>(path);
		return ShowPopUpUI(ui);
	}

	public void ClosePopUpUI()
	{
		PopUpUI ui = popUpStack.Pop();
		GameManager.Pool.Release(ui.gameObject);

		if (popUpStack.Count > 0)
		{
			PopUpUI curUI = popUpStack.Peek();
			curUI.gameObject.SetActive(true);
		}
		if (popUpStack.Count == 0)
		{
			Time.timeScale = 1;
		}
	}

	public void ShowWindowUI(WindowUI windowui)
	{
		WindowUI ui = GameManager.Pool.GetUI(windowui);
		ui.transform.SetParent(popUpCanvas.transform, false);
	}

	public void ShowWindowUI(string path)
	{
		WindowUI ui = GameManager.Resource.Load<WindowUI>(path);
		ShowWindowUI(ui);
	}

	public void SelectWindowUI(WindowUI windowui)
	{
		windowui.transform.SetAsLastSibling();
	}

	public void CloseWindowUI(WindowUI windowui)
	{
		GameManager.Pool.Release(windowui.gameObject);
	}

	public T ShowInGameUI<T>(T inGameUI) where T : InGameUI
	{
		T ui = GameManager.Pool.GetUI(inGameUI);
		ui.transform.SetParent(inGameCanvas.transform, false);

		return ui;
	}

	public T ShowInGameUI<T>(string path) where T : InGameUI
	{
		T ui = GameManager.Resource.Load<T>(path);
		return ShowInGameUI(ui);
	}

	public void CloseGameUI<T>(T inGameUI) where T : InGameUI
	{
		GameManager.Pool.ReleaseUI(inGameUI.gameObject);
	}

	internal void CloseInGameUI(BuildInGameUI buildInGameUI)
	{
		throw new NotImplementedException();
	}
}