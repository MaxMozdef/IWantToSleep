using TMPro;
using UnityEngine;

public class FirstLevelDiscriptions : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI FirstLevelDiscriptionsText;

    AllLevelDiscriptionTextMessage allLevelDiscriptionTextMessage;

    private void Awake()
    {
        allLevelDiscriptionTextMessage = GetComponent<AllLevelDiscriptionTextMessage>();
    }

    void Start()
    {
        FirstLevelDiscriptionsText.text = allLevelDiscriptionTextMessage.discriptionTextMessages[0];
    }

    void Update()
    {
        HideTheText();
    }

    private void HideTheText()
    {
        if (Input.GetMouseButtonDown(0))
            FirstLevelDiscriptionsText.gameObject.SetActive(false);
    }
}
