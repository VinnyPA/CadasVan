﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cadasvan.Models
{
    public class Motorista
    {
        [Key]
        public int IdMotorista { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Nome de usuario")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Endereço: Av, Rua")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Seu CEP")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Seu Telefone")]
        [Phone]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Seu E-mail")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Sua Senha")]
        [PasswordPropertyText]
        public string Senha { get; set; }
        public List<Aluno> Alunos { get; set; }
        
    }
}
