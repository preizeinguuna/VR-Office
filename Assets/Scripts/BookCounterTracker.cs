using TMPro;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class BookCounterTracker : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    public XRSocketInteractor[] shelfSockets;
    public int totalItemsNeeded = 6;

    // This allows you to set any title in the Inspector (e.g., "Blue Binders" or "Pink Binders")
    public string binderTitle = "Blue Binders";

    void Update()
    {
        int currentCount = 0;

        foreach (var socket in shelfSockets)
        {
            if (socket.hasSelection)
            {
                currentCount++;
            }
        }

        if (counterText != null)
        {
            counterText.text = binderTitle + "\nSorted items: " + currentCount + " / " + totalItemsNeeded;
        }
    }
}