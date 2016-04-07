using UnityEngine;
using System.Collections;

/// <summary>
/// Move object that this script is attached to
/// in XY plane - or XZ plane with left shift down -
/// regardless of camera orientation.
/// </summary>
public class MoveObjectXYZScript : MonoBehaviour {
    public float moveFactor = 1f;

    private Vector3 _lastClickPos;

	// Use this for initialization
	void Start () {
	
	}

    void OnMouseDown()
    {
        _lastClickPos = Input.mousePosition;
    }

    void OnMouseDrag()
    {
        var mouseDelta = Input.mousePosition - _lastClickPos;
        _lastClickPos = Input.mousePosition;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            mouseDelta.z = mouseDelta.y;
            mouseDelta.y = 0;
            transform.Translate(mouseDelta * moveFactor);
        }
        else
        {
            transform.Translate(mouseDelta * moveFactor);
        }
    }
}
