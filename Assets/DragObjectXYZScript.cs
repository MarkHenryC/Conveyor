using UnityEngine;
using System.Collections;

/// <summary>
///  Drag non-rigidbody in line with mouse pointer
///  at its current Z location or, if left shift
///  held down, use screen Y movement as world Z 
///  placement. Drop this script on any object
///  to be dragged in 3D with mouse.
///  Mark H Carolan.
/// </summary>
public class DragObjectXYZScript : MonoBehaviour {

    private Vector3 _prevMouseScreen;

    void OnMouseDown()
    {
        _prevMouseScreen = Input.mousePosition;
    }

    void OnMouseDrag()
    {
        var curMousePos = Input.mousePosition;
        var mouseDelta = curMousePos - _prevMouseScreen;
        var curObjScreenPos = Camera.main.WorldToScreenPoint(transform.position);

        curObjScreenPos.x += mouseDelta.x;
        curObjScreenPos.y += mouseDelta.y;

        var output = Camera.main.ScreenToWorldPoint(curObjScreenPos);

        if (Input.GetKey(KeyCode.LeftShift))                // any key you like of course
        {
            output.z += output.y - transform.position.y;    // apply Y world movement to Z
            output.y = transform.position.y;                // neutralise Y movement
        }

        transform.position = output;
        _prevMouseScreen = curMousePos;
    }
}
