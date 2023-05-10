using UnityEngine;
using UnityEngine.Events;

public class TapToPlay : MonoBehaviour
{
    public bool isTapFirstTime { private set; get; }
    public static UnityAction firstTapAction;

    void OnEnable() => firstTapAction += FirstTap;
    void OnDisable() => firstTapAction -= FirstTap;

    void Start()
    {
        isTapFirstTime = false;
    }

    void Update()
    {
        print(isTapFirstTime);
        StartActionFirstTap();
    }

    void FirstTap()
    {
        isTapFirstTime = true;
    }

    void StartActionFirstTap()
    {
        if (Input.GetMouseButtonDown(0))
            firstTapAction.Invoke();
    }
}
