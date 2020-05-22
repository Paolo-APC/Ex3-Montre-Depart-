using System.Windows.Forms;

namespace ApplicationMontre
{
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "PCB";

        // TODO 01 : Dans le menu "Projet" de Visual Studio, choisir l'option "Ajouter une classe..."
        // et nommer le nouveau fichier "Montre.cs"

        //FAIT

        // TODO 02 : En vous référant au diagramme "Ex3 Montre.png" compléter le code de la classe Montre
        // - Rappel : Les constructeurs doivent initialiser tous les champs.
        // - La méthode AvancerUneSeconde() augmente le temps courant d'une seconde et ajuste les heures, minutes et secondes
        //   en conséquence. Par exemple s'il est 23:59:59 le temps courant deviendra 00:00:00
        // - La méthode ObtenirTempsCourant() retourne une chaîne avec les heures, les minutes et les secondes.
        //   Par exemple "23:59:59". Utiliser au besoin ToString("00") 

        // TODO 03 : Déclarer une variable membre privée nommée m_objMontre de type Montre
        Montre m_objMontre;

        //==================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;


            //TODO 04A : Instancier un objet montre à 9:05:42 avec le constructeur à 3 paramètres
            m_objMontre = new Montre(09, 05, 42);

            //TODO 04B : Afficher le temps courant de la montre
            txtAffichageMontre.Text = m_objMontre.ObtenirTempsCourant();

        }

        //============================================================================
        // Evénement associé au tick de l'horloge. À chaque tick, on avance d'une seconde.
        private void btnAvancer_Click(object sender, System.EventArgs e)
        {
            // TODO 05 : 
            // - Avancer le temps courant de la montre d'une seconde
            // - Afficher le temps courant

            m_objMontre.AvancerUneSeconde();
            txtAffichageMontre.Text = m_objMontre.ObtenirTempsCourant();
        }

        //============================================================================
        private void btnDemarrerArreterHorloge_Click(object sender, System.EventArgs e)
        {
            tmrHorloge.Enabled = !tmrHorloge.Enabled;
        }

        //============================================================================
        private void btnInitialiserMontre_Click(object sender, System.EventArgs e)
        {
            //TODO 06A : Instancier un objet montre à 23:59:55 et l'affecter dans m_objMontre
            m_objMontre = new Montre(23, 59, 55);

            //TODO 06B : Afficher le temps courant de la montre
            txtAffichageMontre.Text = m_objMontre.ObtenirTempsCourant();

        }
        //============================================================================
        private void mnuFichierQuitter_Click(object sender, System.EventArgs e)
        {
            Close();
        }

    }
}
