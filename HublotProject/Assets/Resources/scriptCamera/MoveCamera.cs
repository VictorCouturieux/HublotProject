using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    
    public GameObject player;
    private Vector3 offset;
    private Quaternion offQ;
    
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
        offQ = new Quaternion(
            transform.rotation.x - player.transform.rotation.x,
            transform.rotation.y - player.transform.rotation.y,
            transform.rotation.z - player.transform.rotation.z,
            transform.rotation.w - player.transform.rotation.w
            ); 
    }

    // Update is called once per frame
    void Update()
    {
        float newXPosition = player.transform.position.x - offset.x;
        float newZPosition = player.transform.position.z - offset.z;
 
        transform.position = new Vector3(
            player.transform.position.x, 
            player.transform.position.y, 
            player.transform.position.z-0.2f);

        transform.rotation = new Quaternion(
            player.transform.rotation.x,
            player.transform.rotation.y ,
            transform.rotation.z,
            player.transform.rotation.w);
    }
}
