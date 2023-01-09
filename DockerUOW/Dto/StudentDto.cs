using System.ComponentModel.DataAnnotations;

namespace DockerUOW.Dto
{
    public record StudentDto
    (
        int StudentId,

        [Required]
        [MaxLength(200)]
        string Name,

        [Required]
        int Age,

        [Required]
        string Address,

        string Email
    );
}
