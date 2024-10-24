#nullable enable
namespace AppEstudiantes.Data;
using System.Text.Json.Serialization;
using System;

public class Estudiante
{
    [JsonPropertyName("id_estudiantes")]
    public Int32 Id_estudiantes { get; set; }

    [JsonPropertyName("carne")]
    public string? Carne { get; set; }

    [JsonPropertyName("nombres")]
    public string? Nombres { get; set; }

    [JsonPropertyName("apellidos")]
    public string? Apellidos { get; set; }

    [JsonPropertyName("direccion")]
    public string? Direccion { get; set; }

    [JsonPropertyName("telefono")]
    public string? Telefono { get; set; }

    [JsonPropertyName("correo_electronico")]
    public string? CorreoElectronico { get; set; }

    [JsonPropertyName("id_tipo_sangre")]
    public Int32 Id_tipo_sangre { get; set; }

    [JsonPropertyName("fecha_nacimiento")]
    public DateTime? FechaNacimiento { get; set; }
}
