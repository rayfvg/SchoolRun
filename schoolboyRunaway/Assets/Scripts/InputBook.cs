using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputBook : MonoBehaviour
{
    private string num1;
    private string num2;
    private string num3;
    private string num4;

    public GameObject OpenButton;

    public InputField[] InputFields;

    public int Count;
    public int Count2;
    public int Count3;
    public int Count4;

    private void Update()
    {
            if (InputFields[0].interactable == false &&
            InputFields[1].interactable == false &&
            InputFields[2].interactable == false &&
            InputFields[3].interactable == false
            )
            {
                OpenButton.SetActive(true);
            }    
    }
    public void InputAwnfer(string name)
    {
        num1 = name;
        if (num1 == "4")
        {
            Count += 1;
            gameObject.GetComponent<InputField>().interactable = false;
            
        }
    }

    public void InputAwnfer2(string name)
    {
        num2 = name;
        if (num2 == "3")
        {
            Count2 += 1;
            gameObject.GetComponent<InputField>().interactable = false;
            
        }
    }
    public void InputAwnfer3(string name)
    {
        num3 = name;
        if (num3 == "8")
        {
            Count3 += 1;
            gameObject.GetComponent<InputField>().interactable = false;
           
        }
    }
    public void InputAwnfer4(string name)
    {
        num4 = name;
        if (num4 == "4")
        {
            Count4 += 1;
            gameObject.GetComponent<InputField>().interactable = false;
            
        }
    }
}
