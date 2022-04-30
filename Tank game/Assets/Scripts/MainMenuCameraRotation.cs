using UnityEngine;

public class MainMenuCameraRotation : MonoBehaviour {

    public Camera cam;
    public Transform camTransform;

    private bool keepRoatating = false;

    void Start()
    {
        cam = GetComponent<Camera>();
        camTransform = transform;

    }

    void Update()
    {
        camTransform.Rotate(Vector3.up * Time.deltaTime*3);
    }
}
