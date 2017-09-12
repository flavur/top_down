using UnityEngine;

public class CamerFollow : MonoBehaviour {

    public Transform target;
    //the higher the value the faster the camera will lock on to the target
    public float smoothSpeed = 0.125f;
    public float scaleNumber = 1f;
    public Vector3 offSet;
    private Vector3 velocity = Vector3.zero;

    private Camera myCam;

    void Start()
    {
        myCam = GetComponent<Camera>();
    }

    void FixedUpdate()
    {
        myCam.orthographicSize = (Screen.height / 100f) / scaleNumber;
    }

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offSet;
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothSpeed*Time.deltaTime);
        transform.position = smoothedPosition;

        transform.LookAt(target);
    }
}
