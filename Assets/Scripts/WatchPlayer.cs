using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchPlayer : MonoBehaviour
{
    [SerializeField] Transform playerPosition;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(playerPosition);
        transform.Rotate(0, 180, 0);
    }
}
