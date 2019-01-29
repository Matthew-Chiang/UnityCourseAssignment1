using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnMouseDown()
    {
      transform.Rotate(0,10,0);
    }
}
