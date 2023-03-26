using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Calculator : MonoBehaviour {

    [SerializeField] private TextMeshProUGUI displayText;
    [SerializeField] private TextMeshProUGUI displayOperator;
    [SerializeField] private TextMeshProUGUI displayResult;
    [SerializeField] private AudioSource buttonClick;


    private int CurrentNumber;
    private string tempNumberHolder;


    private void Start () 
    {
        buttonClick.Stop();
    }
    
    //stores CurrentNumber as 1;
    //calls a function to display the current number with the number already on screen.

    public void OnClickButton_1()
    {
        CurrentNumber = 1;
        SetDisplayInput(CurrentNumber);
        buttonClick.Play();
    }
    
    public void OnClickButton_2()
    {
        CurrentNumber = 2;
        SetDisplayInput(CurrentNumber);
        buttonClick.Play();
    }
	
    public void OnClickButton_3()
    {
        CurrentNumber = 3;
        SetDisplayInput(CurrentNumber);
        buttonClick.Play();
    }

    public void OnClickButton_4()
    {
        CurrentNumber = 4;
        SetDisplayInput(CurrentNumber);
        buttonClick.Play();
    }

    public void OnClickButton_5()
    {
        CurrentNumber = 5;
        SetDisplayInput(CurrentNumber);
        buttonClick.Play();
    }
    public void OnClickButton_6()
    {
        CurrentNumber = 6;
        SetDisplayInput(CurrentNumber);
        buttonClick.Play();
    }

    public void OnClickButton_7()
    {
        CurrentNumber = 7;
        SetDisplayInput(CurrentNumber);
        buttonClick.Play();
    }

    public void OnClickButton_8()
    {
        CurrentNumber = 8;
        SetDisplayInput(CurrentNumber);
        buttonClick.Play();
    }

    public void OnClickButton_9()
    {
        CurrentNumber = 9;
        SetDisplayInput(CurrentNumber);
        buttonClick.Play();
    }

    public void OnClickButton_0()
    {
        CurrentNumber = 0;
        SetDisplayInput(CurrentNumber);
        buttonClick.Play();
    }

    public void OnClickButton_dot()
    {
        buttonClick.Play();
        tempNumberHolder = tempNumberHolder + ".";
        displayText.text = tempNumberHolder;
    }

    public void OnClickButton_delete()
    {
        buttonClick.Play();

        string toBeRemoved = displayText.GetComponent<TextMeshProUGUI>().text;
        if(toBeRemoved != "")
        {
            int length = toBeRemoved.Length;

            displayText.text = tempNumberHolder.Remove(length - 1);
            tempNumberHolder = displayText.GetComponent<TextMeshProUGUI>().text;
        }
    }

    //DIVISION OPERATOR

    public void OnClickButton_division()
    {
        buttonClick.Play();

        displayOperator.text = "/";
        float result = float.Parse(displayResult.GetComponent<TextMeshProUGUI>().text);
        if (result < 1)
        {
            displayResult.text = tempNumberHolder;
        }
        else
        {
            float divided = result / float.Parse(tempNumberHolder);
            displayResult.text = divided + "";
        }
        tempNumberHolder = "";

        OnCheckOperator("/");
    }

    //MULTIPLICATION OPERATOR

    public void OnClickButton_multiply()
    {
        buttonClick.Play();

        displayOperator.text = "*";
        float result = float.Parse(displayResult.GetComponent<TextMeshProUGUI>().text);
        if (result < 1)
        {
            displayResult.text = tempNumberHolder;
        }
        else
        {
            float multiplied = result * float.Parse(tempNumberHolder);
            displayResult.text = multiplied + "";
        }
        tempNumberHolder = "";
        
        OnCheckOperator("*");
    }

    //SUBTRACTION OPERATOR

    public void OnClickButton_subtraction()
    {
        buttonClick.Play();

        displayOperator.text = "-";
        float result = float.Parse(displayResult.GetComponent<TextMeshProUGUI>().text);
        if(result < 1)
        {
            displayResult.text = tempNumberHolder;
        }
        else
        {
            float subtracted = result - float.Parse(tempNumberHolder);
            displayResult.text = subtracted + "";
        }
        tempNumberHolder = "";

        OnCheckOperator("-");
    }
    //ADDITION OPERATOR
    
    public void OnClickButton_addition()
    {
        buttonClick.Play();

        displayOperator.text = "+";
        float result = float.Parse(displayResult.GetComponent<TextMeshProUGUI>().text);
        if (result < 1){
            displayResult.text = tempNumberHolder;
        }
        else
        {
            float finalResult = float.Parse(tempNumberHolder) + result;
            displayResult.text = finalResult + "";
        }
        tempNumberHolder = "";

        OnCheckOperator("+");
    }

    //EQUAL BUTTON

    public void OnClickButton_equal()
    {
        buttonClick.Play();

        if (displayOperator.text == "+")
        {
            float outputNumber = float.Parse(displayResult.GetComponent<TextMeshProUGUI>().text);
            if (outputNumber < 1)
            {
                displayResult.text = tempNumberHolder;
            }
            float resultOnScreen = float.Parse(tempNumberHolder) + outputNumber;
            displayResult.text = resultOnScreen + "";

            tempNumberHolder = "";
        }
        if(displayOperator.text == "-")
        {
            float result = float.Parse(displayResult.GetComponent<TextMeshProUGUI>().text);
            if (result < 1)
            {
                displayResult.text = tempNumberHolder;
            }
            else
            {
                float subtracted = result - float.Parse(tempNumberHolder);
                displayResult.text = subtracted + "";
            }
            tempNumberHolder = "";
        }
        if(displayOperator.text == "*")
        {
            float result = float.Parse(displayResult.GetComponent<TextMeshProUGUI>().text);
            if (result < 1)
            {
                displayResult.text = tempNumberHolder;
            }
            else
            {
                float multiplied = result * float.Parse(tempNumberHolder);
                displayResult.text = multiplied + "";
            }
            tempNumberHolder = "";
        }
        if(displayOperator.text == "/")
        {
            float result = float.Parse(displayResult.GetComponent<TextMeshProUGUI>().text);
            if (result < 1)
            {
                displayResult.text = tempNumberHolder;
            }
            else
            {
                float divided = result / float.Parse(tempNumberHolder);
                displayResult.text = divided + "";
            }
            tempNumberHolder = "";
        }

        displayOperator.text = "=";
    }
       
    public void OnClickButton_AC()
    {
        buttonClick.Play();
        displayOperator.text = "C";
        if(displayOperator.text == "C")
        {
            displayText.text = "0.0";
            displayResult.text = "0";
            tempNumberHolder = "";
        }
    }

    public void OnClickExitButton()
    {
        buttonClick.Play();
        Application.Quit();
    }

    //OUTPUTS INPUT BY USER

    public void SetDisplayInput(int Value)
    {
        tempNumberHolder = tempNumberHolder + Value;
        displayText.text = tempNumberHolder;
    }

    public void OnCheckOperator(string operators)
    {
        if(operators == "+")
        {
            Debug.Log("Carry out addition");
        }
        else if(operators == "-")
        {
            Debug.Log("Carry out subraction");
        }
        else if(operators == "/")
        {
            Debug.Log("Carry out division");
        }
        else
        {
            Debug.Log("Carry out multiplication");
        }
    }
}

    