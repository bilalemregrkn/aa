using System;
using UnityEngine;

public class CenterCollider : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag($"BulletCenter"))
		{
			var bulletCenter = col.GetComponent<BulletCenterCollider>();
			bulletCenter.MyBullet.OnCompleted(transform.parent);
		}
	}
}