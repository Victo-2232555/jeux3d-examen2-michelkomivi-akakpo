using UnityEngine;

/// <summary>
/// Conserve l'état des animations et prévient les surfaces lorsqu'il change.
/// </summary>
public class GestionnaireAnimation : MonoBehaviour
{
    public bool AnimationsActives { get; private set; } = true;

    public event System.Action<bool> EtatAnimationChange;

    /// <summary>
    /// Arrête les animations pour le reste de la partie.
    /// </summary>
    public void ArreterAnimations()
    {
        if (!AnimationsActives)
            return;

        AnimationsActives = false;
        EtatAnimationChange?.Invoke(AnimationsActives);
    }
}
