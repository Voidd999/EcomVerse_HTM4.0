using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CartUI : MonoBehaviour
{
    public ProductSO itemToAdd;
    public CartSO cartSO;
    public Transform cartPanel;
    public TextMeshProUGUI totalPriceText;
    public GameObject productPanel;

    public void AddToCart()
    {
        if (itemToAdd != null)
        {
            cartSO.cartItems.Add(itemToAdd);
            UpdateCartDisplay();
        }
    }

    void UpdateCartDisplay()
    {
        // Clear the cart panel before updating
        foreach (Transform child in cartPanel)
        {
            Destroy(child.gameObject);
        }

        // Display cart contents in the Rect Panels within the cart panel
        float total = 0f;

        foreach (ProductSO item in cartSO.cartItems)
        {
            GameObject itemPanel = Instantiate(productPanel, cartPanel);
            TextMeshProUGUI[] textElements = itemPanel.GetComponentsInChildren<TextMeshProUGUI>();
            textElements[0].text = item.title;
            textElements[1].text = $"Price: ${item.cost}";
            textElements[2].text = $"Quantity: {item.quantity}";

            total += item.cost * item.quantity;
        }

        //if (totalPriceText != null)
        //{
        //    totalPriceText.text = $"Total Cost: ${total}";
        //}
    }
}
