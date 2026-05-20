using UnityEngine;

public class CampfireToggle : MonoBehaviour
{
    [SerializeField] private GameObject fireEffect;

    private bool isOn = false;

    public void ToggleFire()
    {
        isOn = !isOn;
        fireEffect.SetActive(isOn);
    }
}