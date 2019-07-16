using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float moveSpeed;
    public float rotationSpeed;
    public bool isCamFixed;
    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            isCamFixed = !isCamFixed;
        }

        if (!isCamFixed)
        {
            if (Input.GetAxis("Vertical") != 0)
            {
                cam.transform.Translate(0.0f, 0.0f, moveSpeed / 10.0f * Input.GetAxis("Vertical"), Space.World);
            }

            if (Input.GetAxis("Horizontal") != 0)
            {
                cam.transform.Translate(moveSpeed / 10.0f * Input.GetAxis("Horizontal"), 0.0f, 0.0f, Space.World);
            }

            if (Input.GetAxis("Mouse ScrollWheel") != 0)
            {
                cam.transform.Translate(0.0f, moveSpeed / 2.0f * Input.GetAxis("Mouse ScrollWheel"), 0.0f, Space.World);
            }

            if (Input.GetAxis("Mouse X") != 0)
            {
                cam.transform.Rotate(0.0f, rotationSpeed / 2.0f * Input.GetAxisRaw("Mouse X"), 0.0f, Space.World);
            }

            if (Input.GetAxis("Mouse Y") != 0)
            {
                cam.transform.Rotate(rotationSpeed / 2.0f * Input.GetAxisRaw("Mouse Y"), 0.0f, 0.0f, Space.Self);
            }
        }
    }
}
