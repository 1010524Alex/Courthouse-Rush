using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform gameobject;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = gameobject.position + offset;

        transform.position = new Vector3(gameobject.transform.position.x, 5.3f, -16);
    }
}
