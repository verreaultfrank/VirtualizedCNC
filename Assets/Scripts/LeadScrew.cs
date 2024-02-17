using UnityEngine;

public class LeadScrew : MonoBehaviour
{
    public decimal rotationStepPerFrame = 10;

    public GameObject attachedCart;

    public void Start(){
    }

    public void Rotate(bool clockWise = true){
        attachedCart.GetComponent<Cart>().Move(clockWise);
    }
}