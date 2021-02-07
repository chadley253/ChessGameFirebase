using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingBarForImages : MonoBehaviour
{

    public GameObject LoadingBar;

    private Slider Bar;

    public float MaxTimeForBar = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        Bar = gameObject.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        MaxTimeForBar -= Time.deltaTime;
        if (MaxTimeForBar < 5f)
        {
            if (Bar.value < 1)
            {
                Bar.value += 0.25f * Time.deltaTime;
            }
            if (Bar.value == Bar.maxValue)
            {
                this.gameObject.SetActive(false);
            }

        }

    }
}
