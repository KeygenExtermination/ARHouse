using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUrl : MonoBehaviour
{
    public string Url;

    public void Openurl(string Urlname)
    {
        Application.OpenURL(Urlname);
    }
}
