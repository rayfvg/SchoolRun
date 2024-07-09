using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using YG;

public class AdsReward1 : MonoBehaviour
{


    // ������������� �� ������� �������� ������� � OnEnable
    private void OnEnable() => YandexGame.RewardVideoEvent += Rewarded;

    // ������������ �� ������� �������� ������� � OnDisable
    private void OnDisable() => YandexGame.RewardVideoEvent -= Rewarded;

    // ����������� ����� ��������� �������
    void Rewarded(int id)
    {
        // ���� ID = 1, �� ����� "+100 �����"
        if (id == 1)
            Continue1();

        // ���� ID = 2, �� ����� "+������".
        else if (id == 2)
            Continue2();
        else if (id == 3)
            SecretOver();
    }

    // ����� ��� ������ ����� �������
    public void ExampleOpenRewardAd(int id)
    {
        // �������� ����� �������� ����� �������
        YandexGame.RewVideoShow(id);
    }

    public void Continue1()
    {
        PlayerPrefs.SetInt("ThisScene", 22);
        SceneManager.LoadScene(0);
        this.gameObject.SetActive(false);
    }

    public void Continue2()
    {
        PlayerPrefs.SetInt("ThisScene", 29);
        SceneManager.LoadScene(0);
        this.gameObject.SetActive(false);
    }

    public void SecretOver()
    {
        PlayerPrefs.SetInt("ThisScene", 39);
        SceneManager.LoadScene(0);
        this.gameObject.SetActive(false);
    }
}
