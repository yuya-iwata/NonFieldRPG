using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//StageUI
public class StageUIManager : MonoBehaviour
{
    public Text stageText;
    public GameObject nextButton;
    public GameObject toTownButton;
    public void UpdateUI(int currentStage)
    {
        stageText.text = string.Format("ステージ : {0}", currentStage + 1);
    }
    public void ShowButtons(bool isValid)
    {
        nextButton.SetActive(isValid);
        toTownButton.SetActive(isValid);
    }
}
