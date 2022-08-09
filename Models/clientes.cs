using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using testbinding.Models;

namespace testbinding.Models
{
    [Table("Clientes")]
    public class Clientes
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "varchar(60)")]
        [MaxLength(150)]
        [Required(ErrorMessage = "Obrigatório inserir o nome do cliente")]
        public string Nome { get; set; }
        [Column(TypeName = "varchar(40)")]
        [MaxLength(40)]
        public string  Endereco { get; set; }
        [Column(TypeName = "int")]
        public int Numero { get; set; }
        [Column(TypeName = "varchar(40)")]
        [MaxLength(40)]
        public string Bairro { get; set; }

        public Municipios Municipios { get; set; }

        public Uf Uf { get; set; }

        [Column(TypeName = "varchar(14)")]
        [MaxLength(14)]
        public string CPF { get; set; }

        [Column(TypeName = "varchar(14)")]
        [MaxLength(14)]
        public string RG { get; set; }

        public byte[] Foto { get; set; }

        [Column(TypeName = "varchar(15)")]
        [MaxLength(15)]
        [Required(ErrorMessage = "Obrigatório inserir o telefone do cliente")]
        public string Telefone { get; set; }
    }
}
