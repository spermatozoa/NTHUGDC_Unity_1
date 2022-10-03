using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XYZLookAtCamera : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        if(target == null){
            Debug.LogError("target is null", gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
    }
}
