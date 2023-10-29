using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ProductSO", menuName = "productSO", order = 1)]
public class ProductSO : ScriptableObject
{
    public string title;
    public float id;
    [Multiline]public string description;
    public float cost;
    public int quantity = 1;
    public bool isFavourite;
}
