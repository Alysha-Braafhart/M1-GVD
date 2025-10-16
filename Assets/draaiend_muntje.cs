using JetBrains.Annotations;
using UnityEngine;

public class draaiend_muntje : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.left, 80.0F * Time.deltaTime);
    }
}
