using UnityEngine;

public class CapsuleScaling : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;

    private void Start()
    {
        
    }

    private void Update()
    {
        transform.localScale += new Vector3(_scaleSpeed, _scaleSpeed, _scaleSpeed) * Time.deltaTime;
    }
}