using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shapeShifter : MonoBehaviour
{
    [SerializeField] GameObject _mainChar;
    [SerializeField] GameObject _bird;
    [SerializeField] GameObject _human;
    [SerializeField] GameObject _bear;
    [SerializeField] GameObject _wildPig;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _mainChar.SetActive(true);
            _bird.SetActive(false);
            _human.SetActive(true);
            //_bear.SetActive(false);
            //_wildPig.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _mainChar.SetActive(true);
            _bird.SetActive(true);
            _human.SetActive(false);
            //_bear.SetActive(false);
            //_wildPig.SetActive(false);
        }

        
    }
}
