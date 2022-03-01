using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Transform previousroom;
    [SerializeField] private Transform nextroom;
    [SerializeField] private CameraController cam;

    private void onTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if (collision.transform.position.x < transform.position.x)
                cam.MoveToNewRoom(nextroom);
            else
                cam.MoveToNewRoom(previousroom);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
