using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform _targetBall;
    [SerializeField] private float _moveSpeed;
    
    void LateUpdate()
    {
        transform.LookAt (_targetBall);
        transform.position = Vector3.MoveTowards(transform.position, _targetBall.transform.position, _moveSpeed);
    }
}
