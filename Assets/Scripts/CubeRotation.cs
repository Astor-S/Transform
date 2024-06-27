using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    private void Start()
    {
        
    }

    private void Update()
    {
        transform.Rotate(Vector3.up, _rotationSpeed * Time.deltaTime);
    }
}