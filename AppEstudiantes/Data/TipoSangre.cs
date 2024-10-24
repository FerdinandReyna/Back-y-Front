#nullable enable
namespace AppEstudiantes.Data;
using System.Text.Json.Serialization;

public class TipoSangre
{
    [JsonPropertyName("id_tipo_sangre")]
    public int Id_tipo_sangre { get; set; }

    [JsonPropertyName("nombre")]
    public string? Nombre { get; set; }
}
