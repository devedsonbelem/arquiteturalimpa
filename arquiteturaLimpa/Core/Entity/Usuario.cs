using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace arquiteturaLimpa.Core.Entity
{
    [Table("usuarios")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { set; get; }

        [Required]
        [Column("nome")]
        public  string Nome { set; get; }

        [Required]
        [Column("email")]
        public string Email { set; get; }

        [Required]
        [Column("password")]
        public string Password { set; get; }

        [Required]
        [Column("ativo")]
        public int Ativo { set; get; }

        [Required]
        [Column("perfil")]
        public string Perfil { set; get; }
     
         public Usuario(int Id, string Nome, string Email, int Ativo, string Password, string Perfil)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Email = Email;
            this.Ativo = Ativo;
            this.Password = Password;
            this.Perfil = Perfil;
        }

        public Usuario()
        {
        }

        public override string ToString()
        {
            return this.Id + "," + this.Nome + "," + this.Email + "," + this.Ativo + "," + this.Password + "," + this.Perfil;
        }
    }
 }
