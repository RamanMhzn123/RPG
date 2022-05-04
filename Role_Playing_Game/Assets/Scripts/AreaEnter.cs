using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEnter : MonoBehaviour
{
    public string transitonEnterName;

    // Start is called before the first frame update
    void Start()
    {
        if (transitonEnterName == Player.instance.transitonName)
        {
            Player.instance.transform.position = transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
