using UnityEngine;
using UnityEngine.SceneManagement;

public class NavegacionPrincipal : MonoBehaviour
{
    [Header("Configuración de Escenas o Paneles")]
    [Tooltip("El GameObject del panel del menú emergente lateral, si se encuentra en la misma escena.")]
    [SerializeField] private GameObject panelMenuEmergente;

    [Tooltip("El GameObject del panel de configuración, si se encuentra en la misma escena.")]
    [SerializeField] private GameObject panelConfiguracion;

    /// <summary>
    /// Evento disparado al presionar el botón "Resolver el caso".
    /// </summary>
    public void ResolverCaso()
    {
        Debug.Log("ResolverCaso: Se ha iniciado la resolución del caso.");
        // TODO: Cargar la escena de resolución o mostrar panel de culpables.
        // Ejemplo de cambio de escena:
        // SceneManager.LoadScene("ResolucionCasoScene");
    }

    /// <summary>
    /// Evento para alternar o mostrar el panel del menú emergente (Libro abierto).
    /// </summary>
    public void AlternarMenuEmergente()
    {
        if (panelMenuEmergente != null)
        {
            bool estaActivo = panelMenuEmergente.activeSelf;
            panelMenuEmergente.SetActive(!estaActivo);
            Debug.Log($"AlternarMenuEmergente: Menú emergente {( !estaActivo ? "Abierto" : "Cerrado" )}.");
        }
        else
        {
            Debug.LogWarning("NavegacionPrincipal: No se ha asignado la referencia del Panel del Menú Emergente. Cargando escena o simulando...");
            // Si el menú emergente estuviera en otra escena aditiva:
            // SceneManager.LoadScene("MenuEmergenteScene", LoadSceneMode.Additive);
        }
    }

    /// <summary>
    /// Evento para abrir el panel de configuración.
    /// </summary>
    public void AbrirConfiguracion()
    {
        if (panelConfiguracion != null)
        {
            panelConfiguracion.SetActive(true);
            Debug.Log("AbrirConfiguracion: Panel de configuración abierto.");
        }
        else
        {
            Debug.Log("AbrirConfiguracion: Botón de configuración presionado.");
        }
    }

    /// <summary>
    /// Evento para cerrar el panel de configuración.
    /// </summary>
    public void CerrarConfiguracion()
    {
        if (panelConfiguracion != null)
        {
            panelConfiguracion.SetActive(false);
            Debug.Log("CerrarConfiguracion: Panel de configuración cerrado.");
        }
    }
}
