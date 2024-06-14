using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; 
    public float smoothSpeed = 0.125f;
    public Vector3 offset; 
    public float minZoom = 5f; 
    public float maxZoom = 15f; 
    public float zoomLimiter = 50f; 

    private Camera cam;
    private Vector3 lastTargetPosition;
    private float targetSpeed;

    void Start()
    {
        cam = GetComponent<Camera>();
        lastTargetPosition = target.position;
    }

    void LateUpdate()
    {
        if (target != null)
        {
            
            Vector3 desiredPosition = target.position + offset;
            desiredPosition.z = transform.position.z; 
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

            
            targetSpeed = (target.position - lastTargetPosition).magnitude / Time.deltaTime;
            lastTargetPosition = target.position;

            
            float newZoom = Mathf.Lerp(maxZoom, minZoom, targetSpeed / zoomLimiter);
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, newZoom, Time.deltaTime);
        }
    }
}
