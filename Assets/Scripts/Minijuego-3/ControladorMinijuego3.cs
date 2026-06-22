using UnityEngine;
using TMPro;

public class ControladorMinijuego3 : MonoBehaviour
{
    [Header("Datos de Configuración")]
    [Tooltip("El ScriptableObject con la información general del caso, incluyendo la del minijuego.")]
    public DatosCaso casoActual;

    [Header("Referencias de UI")]
    [SerializeField] private TextMeshProUGUI textoTitulo;
    [SerializeField] private TextMeshProUGUI textoSubtitulo;
    [SerializeField] private TextMeshProUGUI textoDescripcion;

    private void OnEnable()
    {
        InicializarUI();
    }

    /// <summary>
    /// Asigna los textos dinámicos a la interfaz gráfica.
    /// </summary>
    public void InicializarUI()
    {
        if (casoActual == null)
        {
            Debug.LogWarning("ControladorMinijuego3: No se ha asignado el DatosCaso en el inspector.");
            return;
        }

        if (textoTitulo != null)
        {
            textoTitulo.text = casoActual.tituloMinijuego;
        }

        if (textoSubtitulo != null)
        {
            textoSubtitulo.text = casoActual.nombreMinijuego;
        }

        if (textoDescripcion != null)
        {
            textoDescripcion.text = casoActual.descripcionMinijuego;
        }
    }
}
