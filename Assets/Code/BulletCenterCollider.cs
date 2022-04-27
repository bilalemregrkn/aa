using UnityEngine;

public class BulletCenterCollider : MonoBehaviour
{
	public BulletController MyBullet => myBullet;
	[SerializeField] private BulletController myBullet;
}