using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class UITextControler : MonoBehaviour
{
    private Text txtLabel;

    public void UpdateText(IntData data)
    {
        //Text is a string, but IntData is an Int. We have to change Int to String
        txtLabel.text = data.value.ToString();
    }
    
    //Awake runs before start
    void Awake()
    {
        txtLabel = GetComponent<Text>();
    }


}
