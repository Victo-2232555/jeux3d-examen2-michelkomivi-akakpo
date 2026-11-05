using UnityEngine;

/// <summary>
/// Ajouter une charge d'accélération à un objet pour augmenter sa texteVitesse lorsqu'il est activé.
/// </summary>
public class ChargeAcceleration : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Si l’objet qui traverse possède le composant Boule, donne-lui une charge et fais disparaître le collectable.
        if (other.TryGetComponent(out Boule boule))
        {
            boule.AjouterChargeAcceleration();
            Destroy(gameObject);
        }
    }
}
