using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    int currentStage = 0; // �X�e�[�W�̐i�s�x
    public void OnNextButton()
    {
        currentStage++;
        Debug.Log("�i�s�x����"+ currentStage);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
