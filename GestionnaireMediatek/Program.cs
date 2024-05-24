using System;
using System.Windows.Forms;
using GestionnaireMediatek.Views;
using GestionnaireMediatek.dal;

namespace GestionnaireMediatek
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entr�e principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            try
            {
                // Initialisation de Access pour g�rer la connexion
                Access.GetInstance();
                Application.Run(new FrmAuthentification());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion � la base de donn�es : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }
    }
}
