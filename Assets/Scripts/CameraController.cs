using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
		
		transform.position = getNewCameraPosition ();
    }

	private Vector3 getNewCameraPosition()
	{
		float newPositionX = player.transform.position.x + offset.x;
		float newPositionY = offset.y; // Don't move camera to top or bottom
		float newPositionZ = player.transform.position.z + offset.z;

		return new Vector3 (newPositionX, newPositionY, newPositionZ);
	}
}
