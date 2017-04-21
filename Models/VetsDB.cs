using System.Data.Entity;

namespace ClinicaVeterinaria.Models {
   public class VetsDB : DbContext {

      //***********************************************
      //  informar a EF que as classes abeixo descritas
      //  devem ser associadas a uma Base de Dados
      //***********************************************
      public virtual DbSet<Donos> Donos { get; set; }
      public virtual DbSet<Animais> Animais { get; set; }


      //***********************************************
      //  onde criar e de que tipo será a Base de Dados
      //***********************************************
      public VetsDB() : base("localizacaoDaBD") { }

   }
}