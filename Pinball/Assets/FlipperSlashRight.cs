using UnityEngine;
using System.Collections;

public class FlipperSlashRight : MonoBehaviour {

    public bool ActivateFlipper;
    public float Timer;
    public GameObject Flipper;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            ActivateFlipper = true;
        }

        if (Timer > 0.06F)
        {
            ActivateFlipper = false;
            //ball.Addforce(-10, 0, -3);
        }

        if (ActivateFlipper)
        {
            transform.RotateAround
                (transform.position,
                Flipper.transform.forward,
                800 * Time.deltaTime);

            Timer = Timer + Time.deltaTime;
        }
    }
}