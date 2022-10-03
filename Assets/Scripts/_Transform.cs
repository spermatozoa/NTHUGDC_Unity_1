using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Transform : MonoBehaviour
{
    public Vector3 pos;
    public Vector3 rotateAngle;
    public Vector3 scale;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject.transform.position);

        //2 ways to move position

        //first
        gameObject.transform.position = pos;

        //second
        gameObject.transform.Translate(pos);

// --------------------------------------------------------------------------------------------------------------------------

        Debug.Log(gameObject.transform.rotation);

        // 2 ways to rotate gameObject

        //first
        gameObject.transform.Rotate(rotateAngle);

        //second
        Quaternion rot = Quaternion.Euler(rotateAngle);
        gameObject.transform.rotation = rot;

// -------------------------------------------------------------------------------------------------------------------------

        Debug.Log(gameObject.transform.localScale);

        transform.localScale = scale;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
