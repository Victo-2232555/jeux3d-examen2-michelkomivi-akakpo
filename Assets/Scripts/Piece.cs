using UnityEngine;

/// <summary>
/// Pièce qui est ajoutée au compteur lorsque la boule la traverse.
/// </summary>
[RequireComponent(typeof(Collider))]
public class Piece : MonoBehaviour
{
    private bool ramassee;

    private void OnTriggerEnter(Collider other)
    {
        if (!ramassee && other.TryGetComponent(out Boule boule))
        {
            ramassee = true;
            boule.AjouterPiece();
            Destroy(gameObject);
        }
    }
}
