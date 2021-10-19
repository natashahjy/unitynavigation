using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWallScript : MonoBehaviour
{
	public Transform[] waypoints;
	public float moveSpeed;
	private int currentPoint = 0;
	private Vector3 target;
	private Vector3 direction;

	void Update()
	{
		if (currentPoint < waypoints.Length)
		{
			target = waypoints[currentPoint].position;
			direction = target - transform.position;
			if (direction.magnitude < 1)
				currentPoint++;

		}
		else
        {
			currentPoint = 0;
		}
		transform.Translate(direction.normalized * moveSpeed * Time.deltaTime);
	}
}
