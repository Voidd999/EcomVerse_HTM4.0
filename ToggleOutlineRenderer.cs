using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ToggleOutlineRenderer : MonoBehaviour
{
	bool isInView;
	bool _enabled;
	public GameObject productPanel;
	public ProductSO productSO;

	[Header("UI Elements")]
	public GameObject _prefabRenderer;
	public TextMeshProUGUI titleText;
	public TextMeshProUGUI priceText;
	public TextMeshProUGUI descriptionText;

	
	public void Toggle(bool enabled)
	{
		isInView = enabled;
		_enabled = enabled;
        productPanel.SetActive(enabled);
		SetProductInPanel();
		//_prefabRenderer.enabled = enabled
	}

	private void LateUpdate()
	{
		if (!isInView && _enabled)
		{
			Toggle(false);
		}
		else isInView = false;
	}

	public void SetProductInPanel()
    {
		AmountUI quantityUI =  productPanel.GetComponent<AmountUI>();
		quantityUI.so = productSO;
		quantityUI.amountText.text = productSO.quantity.ToString();
		titleText.text = productSO.title;
		priceText.text = productSO.cost.ToString();
		descriptionText.text = productSO.description;

		CartUI cartUI = productPanel.GetComponent<CartUI>();
		cartUI.itemToAdd = productSO;
	}


}
