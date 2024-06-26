﻿namespace GestionnaireMediatek.Models
{
    /// <summary>
    /// Classe métier liée à la table Motif.
    /// Représente le motif de l'absence d'un personnel.
    /// </summary>
    public class Motif
    {
        /// <summary>
        /// Identifiant unique du motif de l'absence.
        /// </summary>
        public int IdMotif { get; set; }

        /// <summary>
        /// Libellé du motif de l'absence.
        /// </summary>
        public string Libelle { get; set; }
    }
}
