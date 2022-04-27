using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class BulletController : MonoBehaviour
{
	[SerializeField] private SpriteRenderer line;
	[SerializeField] private TextMeshPro text;

	public void MyStart(int remain)
	{
		text.SetText(remain.ToString());
	}

	public void Move(Vector3 target, float time)
	{
		StartCoroutine(_Move(target, time));
	}

	private IEnumerator _Move(Vector3 targetPosition, float time)
	{
		var passed = 0f;
		var init = transform.position;
		while (passed < time)
		{
			yield return null;
			passed += Time.deltaTime;
			var normalize = passed / time;
			var newPosition = Vector3.Lerp(init, targetPosition, normalize);
			transform.position = newPosition;
		}
	}

	public void OnCompleted(Transform parent)
	{
		transform.SetParent(parent);
		line.enabled = true;
		if (LevelManager.Instance.IsLevelCompleted())
			LevelManager.Instance.OnFinishLevel();
	}
}