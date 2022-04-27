using System;
using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public static GameManager Instance { get; private set; }


	[SerializeField] private ColorManager _colorManager;

	private void Awake()
	{
		Instance = this;
	}

	private void Start()
	{
		OnStart();
	}

	public void OnStart()
	{
		LevelManager.Instance.OnStartLevel();
		_colorManager.SetNormal();
	}

	public void OnGameOver()
	{
		Debug.Log("Game Over");
		Time.timeScale = 0;
		_colorManager.OnFail();
	}

	public void OnSuccess()
	{
		_colorManager.OnSuccess();

		IEnumerator Do()
		{
			yield return new WaitForSeconds(1);
			OnStart();
		}

		StartCoroutine(Do());
	}
}