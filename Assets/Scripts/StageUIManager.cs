using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//StageUI
public class StageUIManager : MonoBehaviour
{
    public Text stageText;
    public void UpdateUI(int currentStage)
    {
        stageText.text = string.Format("�X�e�[�W : {0}", currentStage + 1);
    }
}
