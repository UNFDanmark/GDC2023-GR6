using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class lmao_next : MonoBehaviour
{
    public float timeUntilContinue = Time.deltaTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeUntilContinue -= Time.deltaTime;
        if (timeUntilContinue > 0)
        {
            return;
        }

        if (Input.anyKey)
        {
            SceneManager.LoadScene("scene1");
        }
    }
}
