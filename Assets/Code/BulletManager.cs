using System;
using Unity.Mathematics;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
	public static BulletManager Instance { get; private set; }

	[SerializeField] private Transform target;
	[SerializeField] private Transform home;

	[SerializeField] private BulletController bulletPrefab;
	[Range(0, 1)] [SerializeField] private float moveTime;

	public int bulletRemain;

	private void Awake()
	{
		Instance = this;
	}

	public void SpawnAndMove()
	{
		if (bulletRemain == 0) return;
		var bullet = Instantiate(bulletPrefab, home.position, quaternion.identity);
		bullet.MyStart(bulletRemain);
		bullet.Move(target.position, moveTime);
		bulletRemain--;
	}
}
