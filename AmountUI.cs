using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class AmountUI : MonoBehaviour
{
    public TextMeshProUGUI amountText;
    public Button plusButton;
    public Button minusButton;
    public ProductSO so;
    int amount = 1;
    // Start is called before the first frame update
    private void Start()
    {
    

        plusButton.onClick.AddListener(() =>
        {
            if (amount < 10)
            {
                amount += 1;
                amountText.text = amount.ToString();
                try
                {
                    so.quantity = amount;
                }
                catch(SystemException e) { Debug.Log(e); }
            }
        });

        minusButton.onClick.AddListener(() =>
        {
            if (amount > 1)
            {
                amount -= 1;
                amountText.text = amount.ToString();
                try
                {
                    so.quantity = amount;
                }
                catch (SystemException e) { Debug.Log(e); }
            }
        });
    }
}
