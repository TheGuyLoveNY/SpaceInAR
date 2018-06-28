using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationSpeed = 5f;

    public void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
