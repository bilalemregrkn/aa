using UnityEngine;

public class BulletCollider : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag("Bullet"))
		{
			GameManager.Instance.OnGameOver();
		}
	}
}