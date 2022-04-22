using UnityEngine;

public class CameraMovement : MonoBehaviour {

	public float cameraSpeed = 0.04f;

	private void FixedUpdate () {
		transform.position = new Vector3 (transform.position.x, transform.position.y + cameraSpeed, transform.position.z);
	}

}