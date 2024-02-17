using UnityEngine;
using UnityEngine.UI;

public class CNCController : MonoBehaviour
{
    public GameObject XAxisMotor;
    public GameObject YAxisMotor;
    public GameObject ZAxisMotor;
    public GameObject Spindle;


    public void ToggleMotor(string _name, bool _inverse){
        if(_name == "XMotor")
            ToggleXMotor(_inverse);
        if(_name == "YMotor")
            ToggleYMotor(_inverse);
        if(_name == "ZMotor")
            ToggleZMotor(_inverse);
        if(_name == "Spindle")
            ToggleSpindle(_inverse);
    }

    public void ToggleXMotor(bool _inverse){
        XAxisMotor.GetComponent<Motor>().antiClockWise = _inverse;
        XAxisMotor.GetComponent<Motor>().isRotating = !XAxisMotor.GetComponent<Motor>().isRotating;
    }

    public void ToggleYMotor(bool _inverse){
        YAxisMotor.GetComponent<Motor>().antiClockWise = _inverse;
        YAxisMotor.GetComponent<Motor>().isRotating = !YAxisMotor.GetComponent<Motor>().isRotating;
    }

    public void ToggleZMotor(bool _inverse){
        ZAxisMotor.GetComponent<Motor>().antiClockWise = _inverse;
        ZAxisMotor.GetComponent<Motor>().isRotating = !ZAxisMotor.GetComponent<Motor>().isRotating;
    }

    public void ToggleSpindle(bool _inverse){
        Spindle.GetComponent<Motor>().antiClockWise = _inverse;
        Spindle.GetComponent<Motor>().isRotating = !Spindle.GetComponent<Motor>().isRotating;
    } 
}
