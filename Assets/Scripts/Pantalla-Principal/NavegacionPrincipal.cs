using UnityEngine;
using UnityEngine.SceneManagement;

public class NavegacionPrincipal : MonoBehaviour
{
    [Header("Configuración de Escenas o Paneles")]
    [Tooltip("El GameObject del panel del menú emergente lateral, si se encuentra en la misma escena.")]
    [SerializeField] private GameObject panelMenuEmergente;

    [Tooltip("El GameObject del panel de configuración, si se encuentra en la misma escena.")]
    [SerializeField] private GameObject panelConfiguracion;

    [Tooltip("El GameObject del panel del minijuego para resolver el caso, si se encuentra en la misma escena.")]
    [SerializeField] private GameObject panelMinijuego;

    /// <summary>
    /// Evento disparado al presionar el botón "Resolver el caso".
    /// </summary>
    public void ResolverCaso()
    {
        if (panelMinijuego != null)
        {
            panelMinijuego.SetActive(true);
            Debug.Log("ResolverCaso: Panel de minijuego activado en la misma escena.");
        }
        else
        {
            Debug.LogWarning("NavegacionPrincipal: No se ha asignado la referencia del Panel de Minijuego. Simulando acción...");
        }
    }

    /// <summary>
    /// Evento para alternar o mostrar el panel del menú emergente (Libro abierto).
    /// </summary>
    public void AlternarMenuEmergente()
    {
        if (panelMenuEmergente != null)
        {
            // Intentar obtener el controlador de deslizamiento animado para una transición suave
            MenuEmergenteController controlador = panelMenuEmergente.GetComponent<MenuEmergenteController>();
            if (controlador != null)
            {
                controlador.CambiarEstadoMenu();
            }
            else
            {
                // Si no hay controlador de animación, alternamos visibilidad directa (fallback)
                bool estaActivo = panelMenuEmergente.activeSelf;
                panelMenuEmergente.SetActive(!estaActivo);
                Debug.Log($"AlternarMenuEmergente: Menú emergente {( !estaActivo ? "Abierto" : "Cerrado" )} (visibilidad directa).");
            }
        }
        else
        {
            Debug.LogWarning("NavegacionPrincipal: No se ha asignado la referencia del Panel del Menú Emergente.");
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
