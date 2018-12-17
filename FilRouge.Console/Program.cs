﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilRouge.Domain.Entities;
using FilRouge.Services.Services;
namespace FilRouge.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //définir les modèles
            Candidat newCandidat = new Candidat()
            {
                NomCandidat = "Duval",
                PrenomCandidat = "Michel",
                Telephone = "0214253698",
                Mail = "michou@gmail.com"
            };
            CandidateService newCandidatService = new CandidateService();
            newCandidatService.AddNewCandidate(newCandidat);
            foreach (var x in newCandidatService.GetCandidates())
            {
                System.Console.WriteLine(x.NomCandidat);
            }

            System.Console.ReadKey();

        }
    }
}