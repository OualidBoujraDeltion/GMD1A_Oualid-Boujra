using UnityEngine;
using System.Collections;

public class Timelaunchpower : MonoBehaviour
{
    public float ChargeTime;
    public float tijdmachine;
    public string maxpower;
    public Vector3 force;
    public Rigidbody speler;
    public bool readytolaunch;

    // Update is called once per frame
    void Update(){
        if (readytolaunch == true && Input.GetButtonUp("Jump")){
            speler.AddForce(force * ChargeTime);
        }

        if (Input.GetButtonUp("Jump")){
            readytolaunch = false;
        }

        if (Input.GetButton("Jump"))
            Tim();

        if (ChargeTime >= 3){
            speler.AddForce(force * ChargeTime);
            ChargeTime = 0;
            print(maxpower);
            readytolaunch = false;
        }
    }

    public void Tim(){
        ChargeTime = ChargeTime + (1 * Time.deltaTime);
    }

    public void OnCollisionEnter(Collision collision){
        if (collision.gameObject.tag == "launcher"){
            readytolaunch = true;
        }
    }
}