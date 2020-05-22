using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationMontre
{
    class Montre
    {
        /// <summary>
        /// Constructeur = (PRIVÉ) Contient l'heure. Les secondes, les minutes et les heures
        /// </summary>
        private int m_heures = 0; //Heure

        private int m_minutes = 0; //Minute

        private int m_secondes = 0; //Seconde
        //___________________________________________________________________________________________________
        /// <summary>
        /// 3 Propriété = (PUBLIQUE) Obtient les variables non acessible
        /// </summary>
        public int Heures //1
        {
            get
            {
                return m_heures;
            }
        }

        public int Minutes //2
        {
            get
            {
                return m_minutes;
            }
        }

        public int Secondes //3
        {
            get
            {
                return Secondes;
            }
        }
        //___________________________________________________________________________________________________
        /// <summary>
        /// 4 Méthodes = Calculs pour obtenir une valeur
        /// </summary>
        public void AvancerUneSeconde() //1
        {
            m_secondes++;

            if (m_secondes > 59) //une minute passé
            {
                m_secondes = 0;
                m_minutes++;

                if (m_minutes > 59) //une heure passé
                {
                    m_minutes = 0;
                    m_heures++;

                    if (m_heures > 23) // une journee passe
                    {
                        m_heures = 0;
                    }
                }
            }
        }
        /// <summary>
        ///  Initialise une nouvelle instance de la classe Montre.
        ///  Le temps au départ est 00:00:00
        /// </summary>
        public Montre() //2
        {
            m_secondes = 0;
            m_minutes = 0;
            m_heures = 0;
        }
        /// <summary>
        /// Initialise une nouvelle instance de la classe Montre.
        /// Le temps au départ est celui spécifié par les paramètres.
        /// </summary>
        /// <param name="pHeure">heure</param>
        /// <param name="pMinutes">minute</param>
        /// <param name="pSecondes">seconde</param>
        public Montre(int pHeure, int pMinutes, int pSecondes) //3
        {
            m_secondes = pSecondes;
            m_minutes = pMinutes;
            m_heures = pHeure;
        }

        public string ObtenirTempsCourant() //4
        {
            return m_heures + ":" + m_minutes.ToString("00") + ":" + m_secondes.ToString("00");
        }
    }
}
