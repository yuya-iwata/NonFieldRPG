using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyUIManager : MonoBehaviour
{
    public Text hpText;
    public Text NameText;

    void UpdateUI()
    {
        hpText.text = string.Format("HP : {0}", 80);
    }
}
