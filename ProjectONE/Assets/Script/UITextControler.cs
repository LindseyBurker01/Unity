using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class UITextControler : MonoBehaviour
{
    public UnityEvent startEvent;
    private Text txtLabel;

    public void UpdateText(IntData data)
    {
        //Text is a string, but IntData is an Int. We have to change Int to String
        txtLabel.text = data.value.ToString();
    }
    void Start()
    {
        txtLabel = GetComponent<Text>();
        startEvent.Invoke();
    }


}
