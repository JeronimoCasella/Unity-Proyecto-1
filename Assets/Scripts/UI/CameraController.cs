using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    public static CameraController instance;

    private CinemachineVirtualCamera virtualCamera;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            virtualCamera = GetComponent<CinemachineVirtualCamera>();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetNewFollowTarget(Transform newTarget)
    {
        virtualCamera.Follow = newTarget;
        virtualCamera.LookAt = newTarget;
    }
}