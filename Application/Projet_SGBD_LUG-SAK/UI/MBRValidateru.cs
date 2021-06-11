using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using DTO;

namespace UI
{
    class MBRValidateru : AbstractValidator <MBR>
    {
        public MBRValidateru ()
        {
            RuleFor(mbr => mbr.Mbr_nom).
                NotEmpty().
                WithMessage("Le nom est obligatoire.").
                Length(3, 100).
                WithMessage("La longuer du nom doit être comprise entre 3 et 100 caractères.");

            RuleFor(mbr => mbr.Mbr_prenom).
                NotEmpty().
                WithMessage("Le prénom est obligatoire.").
                Length(3, 100).
                WithMessage("La longuer du prénom doit être comprise entre 3 et 100 caractères.");

            RuleFor(mbr => mbr.Mbr_sexe).
                NotEmpty().
                WithMessage("Le sexe est obligatoire et doit valoir M ou F.");

            RuleFor(mbr => mbr.Mbr_loc).
                NotEmpty().
                WithMessage("La ville est obligatoire.");

            RuleFor(etu => etu.Mbr_cp).
                NotEmpty().
                WithMessage("Le code postal est obligatoire.");

            RuleFor(mbr => mbr.Mbr_mail).
                EmailAddress().
                WithMessage("L'adresse mail n'est pas correcte");

            RuleFor(mbr => mbr.Mbr_adrs).
                NotEmpty().
                WithMessage("L'adresse n'est pas correcte");

            RuleFor(mbr => mbr.Mbr_gsm).
                Must(TextChanged).
                WithMessage("Only numbers are allowed").
                Length(9,25).
                WithMessage("Not correct format");

            RuleFor(mbr => mbr.Mbr_fix_tel).
              Must(TextChanged).
              WithMessage("Only numbers are allowed").
                Length(9, 25).
                WithMessage("Not correct format");

            RuleFor(mbr => mbr.Mbr_naiss).
              Must(ValidationDateDeNaissance).
              WithMessage("Un membre ne peut pas avoir moins de 18 ans.");



        }

        private bool TextChanged(string Mbr_gsm)
        {
            bool retVal =false;
            int result;

            if (int.TryParse(Mbr_gsm,out result))
                retVal = true;
           
          return retVal;
            
        }

        private bool ValidationDateDeNaissance(DateTime ETU_DTE_NAI)
        {
            return ((ETU_DTE_NAI.AddYears(18) <= DateTime.Today));
        }

    }
}
