using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    public Camera firstPersonCamera;
    public Camera overheadCamera;
    // Start is called before the first frame update
    void Start()
    {
      firstPersonCamera.enabled = false;
      overheadCamera.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
          firstPersonCamera.enabled = !firstPersonCamera.enabled;
          overheadCamera.enabled = !overheadCamera.enabled;
        }
    }
}
