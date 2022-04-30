using UnityEngine;

namespace TanksMP
{
	/// Camera script for following the player or a different target transform.
	public class FollowTarget : MonoBehaviour
	{

		/// The camera target to follow.
		/// Automatically picked up in LateUpdate().
		public Transform target;

		/// The clamped distance in the x-z plane to the target.
		public float distance = 10.0f;

		/// The clamped height the camera should be above the target.
		public float height = 5.0f;

		/// Reference to the Camera component.
		[HideInInspector]
		public Camera cam;

		/// Reference to the camera Transform.
		[HideInInspector]
		public Transform camTransform;

		private float goalYRotation;
		private float currentYRotation;
		void Start ()
		{
			cam = GetComponent<Camera> ();
			camTransform = transform;

			Transform listener = GetComponentInChildren<AudioListener> ().transform;
			listener.position = transform.position + transform.forward * distance;
			currentYRotation = transform.eulerAngles.y;
			goalYRotation = currentYRotation;
		}
			
		void LateUpdate()
		{
			if (!target)
				return;

			Quaternion currentRotation = Quaternion.Euler (0, transform.eulerAngles.y, 0);

			Vector3 pos = target.position;
			pos -= currentRotation * Vector3.forward * Mathf.Abs (distance);
			pos.y = target.position.y + Mathf.Abs (height);
			transform.position = pos;

			transform.LookAt (target);

			transform.position = target.position - (transform.forward * Mathf.Abs (distance));

			if (Input.GetKeyDown (KeyCode.E))
			{
				goalYRotation += 90f;
			}
			if (Input.GetKeyDown (KeyCode.Q))
			{
				goalYRotation -= 90f;
			}

			currentYRotation = Mathf.Lerp (currentYRotation, goalYRotation, Time.deltaTime * 1.3f);
			Vector3 rotation = transform.eulerAngles;
			rotation.y = currentYRotation;
			transform.eulerAngles = rotation;
			// q adds 90 to y rotation
			// e minus 90 from y rotation
		}
	}
}