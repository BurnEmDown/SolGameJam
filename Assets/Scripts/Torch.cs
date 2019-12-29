using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Torch : MonoBehaviour
{
    [SerializeField] float horizontalSpeed = 2f;
    [SerializeField] float verizontalSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Screen.lockCursor = true;
        CursorMove();
    }

    private void CursorMove()
    {
        float h = horizontalSpeed * CrossPlatformInputManager.GetAxis("Mouse X");
        float v = verizontalSpeed * CrossPlatformInputManager.GetAxis("Mouse Y");

        transform.Translate(h, 0, v);
    }
}
