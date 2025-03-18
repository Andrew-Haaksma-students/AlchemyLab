using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Objective : MonoBehaviour
{
    [SerializeField] private Text ObjectiveDisplay;
    [SerializeField] private string objectiveText = "I am an Objective";
    [SerializeField] private string completedText = "Wahoo you've completed and objective!";

    public UnityEvent OnCompleteObjective = new UnityEvent();

    private void OnEnable()
    {
        ObjectiveDisplay.text = objectiveText;
    }

    public void CompleteObjective()
    {
        if (gameObject.activeSelf)
        {
            ObjectiveDisplay.text = "";

            OnCompleteObjective.Invoke();

            gameObject.SetActive(false);
        }
    }
}
