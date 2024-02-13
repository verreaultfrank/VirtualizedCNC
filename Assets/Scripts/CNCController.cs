using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CNCController : MonoBehaviour
{
    Motor XAxisMotor;
    GameObject XAxisCart;
    // Start is called before the first frame update
    void Start()
    {
        XAxisMotor = this.gameObject.AddComponent<Motor>();
        XAxisMotor.name = "XAxisMotor";

        XAxisCart = GameObject.Find("XAxisCart");
    }

    // Update is called once per frame
     void Update()
    {
        if(XAxisMotor.isRotating)
            SendCurrentToXMotor();
    }

    public void ToggleXMotor(){
        XAxisMotor.isRotating = !XAxisMotor.isRotating;
    }

    private void SendCurrentToXMotor(){
        XAxisMotor.Rotate();
        XAxisCart.transform.position = Vector3.MoveTowards(XAxisCart.transform.position, new Vector3(XAxisCart.transform.position.x, XAxisCart.transform.position.y, XAxisCart.transform.position.z - (float)XAxisMotor.stepPerFrame), (float)XAxisMotor.stepPerFrame * Time.deltaTime);
    }
}
