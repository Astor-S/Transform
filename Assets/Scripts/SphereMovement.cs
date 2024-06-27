using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Start()
    {
        
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
}