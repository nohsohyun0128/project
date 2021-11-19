using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emotion : MonoBehaviour{

    private bool state1;
    private bool state2;
    private bool state3;
    private bool state4;
    private bool state5;
    public GameObject Target1;
    public GameObject Target2;
    public GameObject Target3;
    public GameObject Target4;
    public GameObject Target5;
    public float _time1;
    public float _time2;
    public float _time3;
    public float _time4;
    public float _time5;

    // Start is called before the first frame update
    void Start()
    {
        state1 = false;
        state2 = false;
        state3 = false;
        state4 = false;
        state5 = false;
        Target1.SetActive(false);
        Target2.SetActive(false);
        Target3.SetActive(false);
        Target4.SetActive(false);
        Target5.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1)) 
        {
            if(state1 == true)
            {
                Target1.SetActive(false);
                state1 = false;
            }
            else
            {
                state1 = true;
                state2 = false;
                state3 = false;
                state4 = false;
                state5 = false;
                Target1.SetActive(true);
                Target2.SetActive(false);
                Target3.SetActive(false);
                Target4.SetActive(false);
                Target5.SetActive(false);

            }
        }

        if (Input.GetKeyDown(KeyCode.F2))
        {
            if (state2 == true)
            {
                Target2.SetActive(false);
                state2 = false;
            }
            else
            {
                state1 = false;
                state2 = true;
                state3 = false;
                state4 = false;
                state5 = false;
                Target1.SetActive(false);
                Target2.SetActive(true);
                Target3.SetActive(false);
                Target4.SetActive(false);
                Target5.SetActive(false);

            }
        }
        
        if (Input.GetKeyDown(KeyCode.F3))
        {
            if (state3 == true)
            {
                Target3.SetActive(false);
                state3 = false;
            }
            else
            {
                state1 = false;
                state2 = false;
                state3 = true;
                state4 = false;
                state5 = false;
                Target1.SetActive(false);
                Target2.SetActive(false);
                Target3.SetActive(true);
                Target4.SetActive(false);
                Target5.SetActive(false);
            }
        }
        
        if (Input.GetKeyDown(KeyCode.F4))
        {
            if (state4 == true)
            {
                Target4.SetActive(false);
                state4 = false;
            }
            else
            {
                state1 = false;
                state2 = false;
                state3 = false;
                state4 = true;
                state5 = false;
                Target1.SetActive(false);
                Target2.SetActive(false);
                Target3.SetActive(false);
                Target4.SetActive(true);
                Target5.SetActive(false);
            }
        }
        
        if (Input.GetKeyDown(KeyCode.F5))
        {
            if (state5 == true)
            {
                Target5.SetActive(false);
                state5 = false;
            }
            else
            {
                state1 = false;
                state2 = false;
                state3 = false;
                state4 = false;
                state5 = true;
                Target1.SetActive(false);
                Target2.SetActive(false);
                Target3.SetActive(false);
                Target4.SetActive(false);
                Target5.SetActive(true);
            }
        }

        if (Target1.gameObject.activeSelf == true)
        {
            _time1 += Time.fixedDeltaTime;
            if (_time1 >= 4.0f)
                Target1.SetActive(false);
                state1 = false;
        }
        else if (Target1.gameObject.activeSelf == false)
        {
            _time1 = 0;
        }

        if (Target2.gameObject.activeSelf == true)
        {
            _time2 += Time.fixedDeltaTime;
            if (_time2 >= 4.0f)
                Target2.SetActive(false);
            state2 = false;
        }
        else if (Target2.gameObject.activeSelf == false)
        {
            _time2 = 0;
        }

        if (Target3.gameObject.activeSelf == true)
        {
            _time3 += Time.fixedDeltaTime;
            if (_time3 >= 4.0f)
                Target3.SetActive(false);
            state3 = false;
        }
        else if (Target3.gameObject.activeSelf == false)
        {
            _time3 = 0;
        }

        if (Target4.gameObject.activeSelf == true)
        {
            _time4 += Time.fixedDeltaTime;
            if (_time4 >= 4.0f)
                Target4.SetActive(false);
            state4 = false;
        }
        else if (Target4.gameObject.activeSelf == false)
        {
            _time4 = 0;
        }

        if (Target5.gameObject.activeSelf == true)
        {
            _time5 += Time.fixedDeltaTime;
            if (_time5 >= 4.0f)
                Target5.SetActive(false);
            state5 = false;
        }
        else if (Target5.gameObject.activeSelf == false)
        {
            _time5 = 0;
        }

    }

}
