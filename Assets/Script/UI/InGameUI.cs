using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameUI : BaseUI
{
	public Transform followTarget;
	public Vector2 followOffset;

	private void LateUpdate()
	{
		if (followTarget != null)
		{
			transform.position = Camera.main.WorldToScreenPoint(followTarget.position) + (Vector3)followOffset;
		}
	}

	public void SetTarget(Transform target)
	{
		 this.followTarget = target;
		 if (followTarget != null)
			{
				transform.position = Camera.main.WorldToScreenPoint(followTarget.position) + (Vector3) followOffset;
			} 
	}
	
	public void SetOffset(Transform target)
	{
		this.followTarget = target;
		if (followTarget != null)
		{
			transform.position = Camera.main.WorldToScreenPoint(followTarget.position) + (Vector3)followOffset;
		}
	}
}
