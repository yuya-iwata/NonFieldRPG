using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public StageUIManager stageUI;

    //�G�ɑ�������e�[�u�� -1�Ȃ瑘�����Ȃ��A0�Ȃ瑘��
    int[] encountTable = { -1, -1, 0, -1, 0,-1 };

    int currentStage = 0; // �X�e�[�W�̐i�s�x

    public void OnNextButton()
    {
        currentStage++;
        //�i�s�x��UI�ɔ��f
        stageUI.UpdateUI(currentStage);
        if (encountTable.Length <= currentStage)
        {
            Debug.Log("�N�G�X�g�N���A");
        }
        else if (encountTable[currentStage] == 0)
        {
            Debug.Log("�G�ɑ���");
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
