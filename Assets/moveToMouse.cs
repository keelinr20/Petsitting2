using UnityEngine;
using System.Collections;

public class moveToMouse : MonoBehaviour
{

	public float speed;
	private Vector3 target;

	void Start()
	{
		target = transform.position;
	}

	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Vector3 newTargetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			newTargetPosition.z = transform.position.z;
			Vector3 dir = newTargetPosition - transform.position;
			float dis = dir.magnitude;
			RaycastHit2D hit = Physics2D.Raycast(transform.position, dir, dis);
			//if (hit.collider == null)
			//{
				target = newTargetPosition;
			//}
		}

		transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);

	}
}

