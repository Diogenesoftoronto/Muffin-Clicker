using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IncrementMuffin : MonoBehaviour
{
    [SerializeField]
    private int _muffinCount  = 0;
    [SerializeField]
    private int _modifier = 0;
    [SerializeField]
    private GameObject _textObject;
    [SerializeField]
    private float _red = 0.20f;
    [SerializeField]
    private float _green =	0.80f;
    [SerializeField]
    private float _blue = 0.20f;
    [SerializeField]
    private float _transparency = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMuffinClick() 
    {
        _muffinCount += 1 + _modifier;
        string _muffinString = _muffinCount.ToString();
        // alter the text in the muffin count object
        if (_textObject == null) 
        {
           _textObject = GameObject.Find("MuffinAmount");
            
        }
          TextMeshProUGUI _muffinTextComponent = _textObject
          .GetComponent<TextMeshProUGUI>();
            _muffinTextComponent.text = _muffinString;
            _muffinTextComponent.color = new Color(_red, _green, _blue, _transparency);
    }
}
