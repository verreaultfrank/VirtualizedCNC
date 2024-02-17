using UnityEngine;

public class Cart : MonoBehaviour{
    public float maxAxialPosition = 0;
    public float minAxialPosition = 0;

    public float stepPerFrame = 0.1f;

    public string axis;

    public bool maximumIsReached = false;

    public void Move(bool forward = true){
        Vector3 towardsVector;
        if(axis == "x"){
            towardsVector = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - ((forward)? 1 : -1)*(float)this.stepPerFrame);
            maximumIsReached = (towardsVector.z >= maxAxialPosition || towardsVector.z <= minAxialPosition);
        }
        else if(axis == "y"){
            towardsVector = new Vector3(this.transform.position.x  - ((forward)? 1 : -1)*(float)this.stepPerFrame, this.transform.position.y, this.transform.position.z);
            maximumIsReached = (towardsVector.x >= maxAxialPosition || towardsVector.x <= minAxialPosition);
        }
        else{
            towardsVector = new Vector3(this.transform.position.x, this.transform.position.y  - ((forward)? 1 : -1)*(float)this.stepPerFrame, this.transform.position.z);
            maximumIsReached = (towardsVector.y >= maxAxialPosition || towardsVector.y <= minAxialPosition);
        }

        if(!maximumIsReached){
            this.transform.position = Vector3.MoveTowards(this.transform.position, towardsVector, (float)this.stepPerFrame * Time.deltaTime);
        }
    }
}