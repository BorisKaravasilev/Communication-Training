using UnityEngine;

public class Ping : MonoBehaviour
{
    public GameObject PingPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
        
            // Does the ray intersect any objects excluding the player layer
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
            {
                Vector3 hitPosition = transform.position + transform.TransformDirection(Vector3.forward) * hit.distance;

                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.green, 0.5f);
                Debug.Log("Did Hit");
                Instantiate(PingPrefab, hitPosition, Quaternion.identity);
            }
            else
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.red, 0.5f);
                Debug.Log("Did not Hit");
            }
        }
    }
    
    void FixedUpdate()
    {

    }
}
