using Unity.Mathematics;
using UnityEngine;

public class ForceQuaternionIdentity : MonoBehaviour
{
	private void LateUpdate()
	{
		transform.rotation = quaternion.identity;
	}
}