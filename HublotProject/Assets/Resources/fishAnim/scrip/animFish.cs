using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class animFish : MonoBehaviour
{
    public GameObject obj;
    public int speed = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 vct = new Vector3(obj.transform.position.x ,obj.transform.position.y, obj.transform.position.z);
        
        transform.RotateAround(vct, Vector3.up, speed * Time.deltaTime );
//        transform.Rotate();
    }
}
