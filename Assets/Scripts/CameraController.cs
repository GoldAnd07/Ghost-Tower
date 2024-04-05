using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Camera _mainCamera;
    private GameObject _followingObject;

    public void Construct(GameObject followingObject) =>
        _followingObject = followingObject;

    private void Start()
    {
        _followingObject = GameObject.FindGameObjectWithTag("Player");
    }

    private void Awake() =>
        _mainCamera = Camera.main;

    private void FixedUpdate() =>
        Following();

    private void Following()
    {
        if (_followingObject == null)
            return;
        
        Vector3 temp = transform.position;
        temp.x = _followingObject.transform.position.x;
        temp.y = _followingObject.transform.position.y;
        temp.z = -10;

        _mainCamera.transform.position = temp;
    }
}