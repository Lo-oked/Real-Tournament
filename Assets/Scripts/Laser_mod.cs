using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_mod : MonoBehaviour
{
    public GameObject laser;
    public bool activated;

    public void On_offMode()
    {
        activated = !activated;

        laser.SetActive(activated);
    }
}
