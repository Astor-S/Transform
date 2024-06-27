using UnityEngine;

public class CubeMovementScaling : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _scaleSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.forward * _movementSpeed * Time.deltaTime);
        transform.localScale += new Vector3(_scaleSpeed, _scaleSpeed, _scaleSpeed) * Time.deltaTime;
        transform.Rotate(Vector3.up, _rotationSpeed * Time.deltaTime);
    }
}