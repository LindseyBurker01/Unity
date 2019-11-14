using System.Collections;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class CodeRoutineClass : MonoBehaviour
{
    public bool canRun = true;
    public IntData index;
    private ParticleSystem pop;
    public float sec = 1f;
    private WaitForSeconds wfsObj;

    public void Start()
    {
        pop = GetComponent<ParticleSystem>();
    }

    public void Run()
    {
        wfsObj = new WaitForSeconds(sec);
        StartCoroutine(OnRun());
    }
    IEnumerator OnRun()
    {
        while (index.value > 0)
        {
            yield return wfsObj;
            pop.Emit(5);
            index.value--;
        }
    }
    
}
