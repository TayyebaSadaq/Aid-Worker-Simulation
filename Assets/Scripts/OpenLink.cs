using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour
{
    public void googletranslate()
    {
        Application.OpenURL("https://translate.google.co.uk");
    }
    public void itranslate()
    {
        Application.OpenURL("https://itranslate.com");
    }
    public void talkingtranslator()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.translate.talkingtranslator&hl=en&pli=1");
    }
}
