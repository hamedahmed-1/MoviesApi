using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Dtos
{
    public class GenreDto
    {
        [MaxLength(length:100)]
        public string Name { get; set; }
    }
}
