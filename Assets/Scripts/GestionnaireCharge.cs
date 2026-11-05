using UnityEngine;

/// <summary>
/// Gestionnaire de charge qui gère les objets de charge disponibles pour le joueur et leur utilisation.
/// </summary>
public class GestionnaireCharge : MonoBehaviour
{
    [SerializeField, Tooltip("Référence aux objets de charge que le joueur peut utiliser.")]
    private GameObject[] objetsCharge;//Le tableau contient trois références dans l’Inspector, donc le maximum est trois.

    // Le nombre de charges disponibles pour le joueur.
    private int nombreCharges;

    public void AjouterCharge()
    {
        if(nombreCharges < objetsCharge.Length)
        {
            nombreCharges++;
            objetsCharge[nombreCharges - 1].SetActive(true);//Le SetActive(true) sert aussi à afficher l’icône
        }
    }


    public bool UtiliserCharge()
    {
        if(nombreCharges == 0)
        {
            return false;
        }

        nombreCharges--;
        objetsCharge[nombreCharges].SetActive(false);
        return true;
    }
}
