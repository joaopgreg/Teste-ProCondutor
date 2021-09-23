using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TesteProCondutor.Model
{
    [Table("Clientes")]
    public class Client
    {
        [Key]
        public int ClientId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório", AllowEmptyStrings = false)]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "Campo obrigatório", AllowEmptyStrings = false)]
        public DateTime DataDeNascimento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório", AllowEmptyStrings = false)]
        public string CPF { get; set; }

        public string Telefone { get; set; }

        public string Celular { get; set; }

        public string Contato { get; set; }

        [Required(ErrorMessage = "Campo obrigatório", AllowEmptyStrings = false)]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Campo obrigatório", AllowEmptyStrings = false)]
        public string EnderecoNumero { get; set; }

        [Required(ErrorMessage = "Campo obrigatório", AllowEmptyStrings = false)]
        public string Bairro { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório", AllowEmptyStrings = false)]
        public string cidade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório", AllowEmptyStrings = false)]
        public string Estado { get; set; }
    }
}
