using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using YG;

public class AdsReward1 : MonoBehaviour
{


    // Подписываемся на событие открытия рекламы в OnEnable
    private void OnEnable() => YandexGame.RewardVideoEvent += Rewarded;

    // Отписываемся от события открытия рекламы в OnDisable
    private void OnDisable() => YandexGame.RewardVideoEvent -= Rewarded;

    // Подписанный метод получения награды
    void Rewarded(int id)
    {
        // Если ID = 1, то выдаём "+100 монет"
        if (id == 1)
            Continue1();

        // Если ID = 2, то выдаём "+оружие".
        else if (id == 2)
            Continue2();
        else if (id == 3)
            SecretOver();
    }

    // Метод для вызова видео рекламы
    public void ExampleOpenRewardAd(int id)
    {
        // Вызываем метод открытия видео рекламы
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
