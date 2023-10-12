using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float currentime = 0f;
    float starttime = 9000f;

    [SerializeField] Text CT;
    // Start is called before the first frame update
    void Start()
    {
        currentime = starttime;
    }

    // Update is called once per frame
    void Update()
    {
        currentime -= 1 * Time.deltaTime;
        print(currentime);
    }
}
