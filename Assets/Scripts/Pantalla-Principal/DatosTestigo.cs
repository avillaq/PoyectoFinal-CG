using UnityEngine;

[CreateAssetMenu(fileName = "NuevoDatosTestigo", menuName = "ScriptableObjects/DatosTestigo", order = 1)]
public class DatosTestigo : ScriptableObject
{
    [Header("Información del Testigo")]
    public string nombreTestigo;
    public string rolTestigo;
    public Sprite fotoTestigo;

    [Header("Testimonio")]
    [TextArea(5, 10)]
    public string textoTestimonio;
}
