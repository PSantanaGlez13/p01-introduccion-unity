using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Transform objectTransform = gameObject.GetComponent<Transform>();
        Debug.Log(gameObject.name + " con tag " + gameObject.tag + ": x= " + objectTransform.localPosition.x + " y= " + objectTransform.localPosition.y + " z= " + objectTransform.localPosition.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
