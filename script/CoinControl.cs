using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        transform.Rotate(new Vector3(180, 0, 0) * Time.deltaTime);
    }

}