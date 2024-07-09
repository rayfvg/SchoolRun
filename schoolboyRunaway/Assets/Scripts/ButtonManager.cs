using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Button[] buttons; // ������ ������

    public GameObject open;
    public GameObject closed;

    void Start()
    {
        foreach (Button btn in buttons)
        {
            btn.onClick.AddListener(() => ButtonClicked(btn));
        }
    }

    void ButtonClicked(Button btn)
    {
        btn.gameObject.SetActive(false); // ��������� ������
        CheckButtons();
    }

    void CheckButtons()
    {
        foreach (Button btn in buttons)
        {
            if (btn.gameObject.activeSelf)
            {
                return; // ���� ���� �� ���� ������ �������, ������� �� ������
            }
        open.SetActive(true);
        closed.SetActive(false);
        }
    }
}