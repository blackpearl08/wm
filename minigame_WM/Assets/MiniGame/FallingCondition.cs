using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingCondition : MonoBehaviour
{
    public GameObject FallingMessage;
    // Start is called before the first frame update
    void Start()
    {
        FallingMessage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y<= -10) { FallingMessage.SetActive(true); }
    }
}
