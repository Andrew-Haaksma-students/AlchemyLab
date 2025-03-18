using System.Runtime.CompilerServices;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float jumpForce = 5.0f;
    private Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    public void Jump()
    {
        if (rigidbody != null)
        {
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
