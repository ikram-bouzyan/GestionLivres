using GestionLivres.Models;
using System;
using GestionLivres.Models;
namespace GestionLivres.Data
{
    public class LivreRepo
    {
        private static List<Livre> livres = new List<Livre>
        {
            new Livre{ISBN=1,Titre="Sophie's world",Auteur="Jostien gaarder",DateEdition =new DateTime(2002,12,12),Resume="hhh" },
            new Livre{ISBN=2,Titre="Sophie's world",Auteur="Jostien gaarder",DateEdition =new DateTime(2002,12,12),Resume="hhh" },
            new Livre{ISBN=3,Titre="Sophie's world",Auteur="Jostien gaarder",DateEdition =new DateTime(2002,12,12),Resume="hhh" },
            new Livre{ISBN=4,Titre="Sophie's world",Auteur="Jostien gaarder",DateEdition =new DateTime(2002,12,12),Resume="hhh" },
        };

        public static List<Livre> GetLivre()
        {
            return livres;
        }
    }
}
