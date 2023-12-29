using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class UpdateEnderecoDto
{
    public string Logradtouro { get; set; }
    public int Numero { get; set; }
}
