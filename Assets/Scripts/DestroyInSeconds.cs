using UnityEngine;

public class DestroyInSeconds : MonoBehaviour
{
    public float seconds = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, seconds);
    }
}
