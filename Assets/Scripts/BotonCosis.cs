using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonCosis : MonoBehaviour
{
	GameObject Sphere;
    // Start is called before the first frame update
    void Start()
    {
        Sphere = GameObject.Find("Sphere");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
public void HagoCosis(){
	Sphere.transform.position = new Vector3( transform.position.x + 2,transform.position.y,transform.position.z);
}
}
