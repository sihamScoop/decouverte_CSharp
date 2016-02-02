using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Type_Generique
{
    public class ListeChaineeEnumerator<T> : IEnumerator<T>
    {
        //private int indice;
        private Chainage<T> courant;
        private ListeChainee<T> listeChainee;
        public ListeChaineeEnumerator(ListeChainee<T> liste)
        {
            courant = null;
            listeChainee = liste;
        }

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            if (courant == null)
            {
                courant = listeChainee._premier;
            }
            else
            {
                courant = courant.suivant;
            }
            //Chainage<T> element = listeChainee.ObtenirElement(indice);
            //return element != null;
            return courant!=null;
        }
        public T Current
        {
            get
            {
                //Chainage<T> element = listeChainee.ObtenirElement(indice);
                if (courant == null)
                {
                    return default(T);
                }
                //return element.valeur;
                return courant.valeur;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        
        public void Reset()
        {
            //indice = -1;
            courant = null;
        }
    }
}
