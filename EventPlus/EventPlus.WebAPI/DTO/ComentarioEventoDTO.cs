using System.ComponentModel.DataAnnotations;

namespace EventPlus.WebAPI.DTO
{
    public class ComentarioEventoDTO
    {
        [Required(ErrorMessage = "A descrição do evento é obrigatório.")]
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "O id do usuário é obrigatório.")]
        public string? IdEvento { get; set; }

        [Required(ErrorMessage = "A id do evento é obrigatório.")]
        public string? IdUsuario { get; set; }
    }
}
