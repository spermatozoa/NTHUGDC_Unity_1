using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Components : MonoBehaviour
{
    private GameObjectA component1;
    private Transform ThisIsTransform;
    private GameObject declaretype;
    private boolcharintfloatstring component2;
    // Start is called before the first frame update
    void Start()
    {
        component1 = gameObject.GetComponent<GameObjectA>();
        // CloseB() is a public function
        component1.CloseC();

        //find the gameObject
        declaretype = GameObject.Find("DeclareType");
        // get its script component
        component2 = declaretype.GetComponent<boolcharintfloatstring>();
        // change value of public variable in component2 
        component2.MyName = "HaHa";
        //print the name
        Debug.Log("new MyName is: " + component2.MyName);

        //特例
        ThisIsTransform = gameObject.GetComponent<Transform>();

        Debug.Log(ThisIsTransform == gameObject.transform);
        Debug.Log(gameObject.transform == transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
