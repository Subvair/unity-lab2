using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewMonoBehaviourScript : MonoBehaviour
{
    public int _intValue;
    public List<int> _list;

    public float _floatValue;
    public string _stringValue;
    public bool _boolValue;
    public Vector3 _vectorValue;
    public double _doubleValue;
    void Start()
    {
        _intValue = 5;
        _list = new List<int>();
        _floatValue = 3.14f;
        _stringValue = "Hello, Unity!";
        _boolValue = true;
        _vectorValue = new Vector3(1.0f, 2.0f, 3.0f);
        _doubleValue = 1.23;

        Debug.Log(_intValue);
        Debug.Log(_list);
        Debug.Log(_floatValue);
        Debug.Log(_stringValue);
        Debug.Log(_boolValue);
        Debug.Log(_vectorValue);
        Debug.Log(_doubleValue);
    }

    void Update()
    {
        
    }
}
