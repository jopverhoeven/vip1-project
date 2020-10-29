using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{

    private Light light;

    public float startRange;
    public float endRange;

    public float initRange;

    private bool increase = false;

    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        light.range = initRange;
    }

    // Update is called once per frame
    void Update()
    {
        if (increase)
        {
            if (light.range > endRange)
            {
                increase = !increase;
            }

            light.range += 0.1f;
        }
        else {
            if (light.range < startRange)
            {
                increase = !increase;
            }

            light.range -= 0.1f;
        }
    }
}
