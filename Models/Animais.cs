using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClinicaVeterinaria.Models {
   public class Animais {

      public int AnimaisID { get; set; } // por ser 'nome da classe' + 'ID', será PK

      public string Nome { get; set; }

      public string Raca { get; set; }
        //fdfffsf
      public string Especie { get; set; }

      public int Idade { get; set; }

      public double Peso { get; set; }


      //****************************************************************************
      //  criar a Chave Forasteira
      //  Um ANIMAL tem Um DONO
      //****************************************************************************
      [ForeignKey("DonoFK")]
      public Donos Dono { get; set; } // relaciona, no C#, um Animal com o seu Dono
      public int DonoFK { get; set; } // na BD vai criar a FK













   }
}