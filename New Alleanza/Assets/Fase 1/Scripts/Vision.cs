using UnityEngine;

public class Vision : MonoBehaviour
{
    public Transform target;

    void FixedUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
    }
}
