﻿using blogpessoal.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blogpessoal
{
    public class Tema : Auditable
    {
        [Key] // Primary Key (Id)
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // IDENTITY(1, 1)
        public long Id { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Descricao { get; set; } = string.Empty;
    }
}
