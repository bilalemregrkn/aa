using System;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
	public static  ColorManager Instance { get; private set; }
	
	[SerializeField] private Color normal;
	[SerializeField] private Color success;
	[SerializeField] private Color fail;
	[SerializeField] private Camera main;

	private void Awake()
	{
		Instance = this;
	}

	public void OnSuccess()
	{
		main.backgroundColor = success;
	}

	public void OnFail()
	{
		main.backgroundColor = fail;
	}

	public void SetNormal()
	{
		main.backgroundColor = normal;
	}
}