using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {

    public bool Knop;
    public float Tijdens;
    public string Lingerie;
    public int Tijd;

	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Jump"))
        {
            Knop = true;
        }
        else Knop = false;

        if (Knop == true){
            Tim();
        }
    }

    public void Tim(){
        Tijdens = Tijdens += Time.deltaTime;
    }
}
