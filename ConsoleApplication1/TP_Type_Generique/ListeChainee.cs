using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Type_Generique
{
    class ListeChainee<T>
    {
       public Chainage<T> _premier { get; private set; }

        public Chainage<T> _dernier
        {
            get
            {
                if (_premier == null)
                {
                    return null;
                }
                Chainage<T> derni = _premier;
                while (derni.suivant != null)
                {
                    derni = derni.suivant;
                }
                return derni;
            }
        }

        public void Ajouter(T element)
        {
            if (_premier == null)
            {
                _premier = new Chainage<T> { valeur = element };
            }
            else
            {
                Chainage<T> AncienneChaine = _dernier;
                AncienneChaine.suivant = new Chainage<T> { valeur = element, precedent = AncienneChaine };
            }
        }

        public Chainage<T> ObtenirElement (int indice)
        {
            Chainage<T> temp = _premier;
            for (int i = 1; i  <= indice; i ++)
            {
                if (temp == null)
                {
                    return null;
                }
                temp = temp.suivant;
            }
            return temp;

        }

        public void Insertion(T element, int indice)
        {
            if (indice == 0)
            {
                if (_premier == null)
                {
                    _premier = new Chainage<T> { valeur = element };
                }
                else
                {
                    Chainage<T> temp = _premier;
                    _premier = new Chainage<T> { suivant = temp, valeur = element };
                    temp.precedent = _premier;
                }
                
            }
            else
            {
                Chainage<T> elementAindice = ObtenirElement(indice);
                if (elementAindice == null)
                {
                    Ajouter(element);
                }
                else
                {
                    Chainage<T> preced = elementAindice.precedent;
                    Chainage<T> temp = preced.suivant;
                    preced.suivant = new Chainage<T> { valeur = element, precedent = preced, suivant = temp };
                }
            }

        }
    }
}
