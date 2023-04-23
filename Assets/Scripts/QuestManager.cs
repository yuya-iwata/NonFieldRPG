using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public StageUIManager stageUI;

    //敵に遭遇するテーブル -1なら遭遇しない、0なら遭遇
    int[] encountTable = { -1, -1, 0, -1, 0,-1 };

    int currentStage = 0; // ステージの進行度

    public void OnNextButton()
    {
        currentStage++;
        //進行度をUIに反映
        stageUI.UpdateUI(currentStage);
        if (encountTable.Length <= currentStage)
        {
            Debug.Log("クエストクリア");
        }
        else if (encountTable[currentStage] == 0)
        {
            Debug.Log("敵に遭遇");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        stageUI.UpdateUI(currentStage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
