using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullZone : MonoBehaviour
{
    public FloatVariable pullZoneScale; // scale of pull circle (the magnetic field)
    public FloatVariable attractionSpeed; // speed of magnetic pull

    private void Start()
    {
        transform.localScale = Vector3.one * pullZoneScale.value; // scale pull zone correctly
    }
}
