using UnityEngine;
using UnityEngine.EventSystems;

public class InputController : MonoBehaviour , IPointerDownHandler
{
	public void OnPointerDown(PointerEventData eventData)
	{
		Debug.Log("OnPointerDown");
		BulletManager.Instance.SpawnAndMove();
	}
}