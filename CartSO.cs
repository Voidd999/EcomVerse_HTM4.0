using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CartSO", menuName = "cartSO")]
public class CartSO : ScriptableObject
{
    public List<ProductSO> cartItems = new List<ProductSO>();
}

