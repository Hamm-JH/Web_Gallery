using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Management.GameManager.Instance.core.mainCamera.transform;
            //GameObject.FindGameObjectWithTag("MainCamera").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(cam);
    }
}
