using System;
using TMPro;
using UnityEngine;

public class LevelController : MonoBehaviour
{
	[Range(0, 400)] [SerializeField] private float speed;
	[Range(1, 20)] [SerializeField] private int bulletAmount;
	[SerializeField] private CenterController centerController;
	[SerializeField] private TextMeshPro textLevel;

	public void MyStart(int index)
	{
		textLevel.SetText($"{index + 1}");
		centerController.StartRotate(speed);
		BulletManager.Instance.bulletRemain = bulletAmount;
	}
}