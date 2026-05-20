using UnityEngine;

public class FishingRodInteraction : MonoBehaviour
{
    [SerializeField] private Animator animator;

    public void PlayFishingAnimation()
    {
        animator.Play("Take 001", 0, 0f);
    }
}