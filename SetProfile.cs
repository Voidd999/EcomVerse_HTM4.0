using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class SetProfile : MonoBehaviour
{
  
    public TMP_InputField firstName;
    public TMP_InputField lastName;
    public TMP_InputField address;
    public TMP_InputField city;
    public TMP_InputField state;
    public TMP_InputField pincode;
    public TMP_InputField country;
    public TMP_InputField email;
    public TMP_InputField nuumber;

    public profileSO profileSo;

    private void Start()
    {
        firstName.text=profileSo.firstName;
        lastName.text = profileSo.lastName ;
        address.text = profileSo.address;
        city.text = profileSo.city;
        state.text = profileSo.state;
        pincode.text = profileSo.postcode ;
        country.text = profileSo.country ;
        email.text = profileSo.email ;
        nuumber.text = profileSo.phone ;
    }
    public void SaveProfile()
    {
        profileSo.firstName = firstName.text;
        profileSo.lastName = lastName.text;
        profileSo.address = address.text;
        profileSo.city = city.text;
        profileSo.state = state.text;
        profileSo.postcode= pincode.text;
        profileSo.country = country.text;
        profileSo.email= email.text;
        profileSo.phone = nuumber.text;
    }
}
