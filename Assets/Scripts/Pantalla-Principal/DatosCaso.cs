using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NuevoDatosCaso", menuName = "ScriptableObjects/DatosCaso", order = 2)]
public class DatosCaso : ScriptableObject
{
    [Header("Detalles del Caso")]
    public string tituloCaso;
    [TextArea(3, 6)]
    public string descripcionCaso;

    [Header("Testigos del Caso")]
    public List<DatosTestigo> testigos = new List<DatosTestigo>();

    [Header("Datos del Minijuego de Resolución")]
    public string tituloMinijuego;
    public string nombreMinijuego;
    [TextArea(5, 10)]
    public string descripcionMinijuego;
}
