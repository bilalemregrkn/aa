using UnityEngine;

public class CenterController : MonoBehaviour
{
	private float _speed;

	public void StartRotate(float speed)
	{
		_speed = speed;
	}

	private void FixedUpdate()
	{
		transform.Rotate(Vector3.forward * (_speed * Time.deltaTime));
	}
}