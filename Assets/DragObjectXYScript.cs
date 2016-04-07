using UnityEngine;
using System.Collections;

public class DragObjectXYScript : MonoBehaviour
{
    private Vector3 _offsetScreen;
    private float _distanceZ;

    void OnMouseDown()
    {
        _distanceZ = Vector3.Distance(transform.position, Camera.main.transform.position);        

        var mousePos = Input.mousePosition;
        mousePos.z = _distanceZ;

        _offsetScreen = mousePos - Camera.main.WorldToScreenPoint(transform.position);
    }

    void OnMouseDrag()
    {
        var mousePos = Input.mousePosition;
        mousePos.z = _distanceZ;

        transform.position = Camera.main.ScreenToWorldPoint(mousePos - _offsetScreen);
    }
}