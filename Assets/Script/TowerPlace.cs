using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class TowerPlace : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler, IDragHandler
{
	[SerializeField] Color normal;
	[SerializeField] Color onMouse;

	private Renderer render;

	private void Awake()
	{
		render = GetComponent<Renderer>();	
	}

	public void OnPointerClick(PointerEventData eventData)
    {
		if (eventData.button == PointerEventData.InputButton.Left)
		{
			Debug.Log("좌클릭");
		}
		else if (eventData.button == PointerEventData.InputButton.Right)
		{
			Debug.Log("우클릭");
		}
    }

	public void OnPointerEnter(PointerEventData eventData)
	{
		render.material.color = onMouse;
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		render.material.color = normal;
	}

	public void OnDrag(PointerEventData eventData)
	{
		transform.position += new Vector3(eventData.delta.x, 0, eventData.delta.y); 
	}
}
