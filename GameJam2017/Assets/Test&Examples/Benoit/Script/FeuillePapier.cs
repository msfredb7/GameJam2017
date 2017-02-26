using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeuillePapier : MonoBehaviour {
    public string text;
    public char enterChar = '$';

    public string NoiceText()
    {
        return text.Replace('$', '\n');
    }
}
