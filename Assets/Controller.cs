using UnityEngine;
using System.Runtime.InteropServices;

public class Controller : MonoBehaviour
{
    public Puck puckA;
    public Puck puckB;

    public void Restart()
    {
        if (puckA)
            puckA.Restart();
        if (puckB)
            puckB.Restart();
    }

    void Start()
    {
    }
}
