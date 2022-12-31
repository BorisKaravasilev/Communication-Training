using Unity.Mathematics;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform Target;
    public bool3 FreezePosition;
    private Vector3 _offset;

    // Start is called before the first frame update
    void Start()
    {
        _offset = Target.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = new Vector3(
            FreezePosition.x ? transform.position.x : Target.position.x + _offset.x,
            FreezePosition.y ? transform.position.y : Target.position.y + _offset.y,
            FreezePosition.z ? transform.position.z : Target.position.z + _offset.z);

        transform.position = newPosition;
    }
}
