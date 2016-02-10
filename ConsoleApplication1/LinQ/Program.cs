using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> liste = new List<int> { 4, 6, 1, 9, 5, 15, 8, 3 };
            Console.WriteLine("Affichage normale");
            foreach (int item in liste)
            {
                if (item>5)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("Affichage avec LINQ");
            IEnumerable<int> requete = from i in liste
                                       where i > 5
                                       select i;
            IEnumerable<int> requeteCroissant = from i in requete
                                                orderby i
                                                select i;
            foreach (int req in requeteCroissant)
            {
                Console.WriteLine(req);
            }

            Console.WriteLine("\n*****************Utilisation de LINQ TO Object***************\n");
            List<Client> listeClient = new List<Client>
            {
                new Client {identifiant=1,nom="nicolas",age=30 },
                 new Client {identifiant=2,nom="jérémie",age=20 },
                  new Client {identifiant=3,nom="delphine",age=30 },
                   new Client {identifiant=4,nom="bob",age=10 },
            };
            IEnumerable<string> requeteObj = from client in listeClient
                                             where client.age > 18
                                             orderby client.age, client.nom
                                             select client.nom;
            Console.WriteLine("Affichage des client par ordre croissant d'age");
            foreach (string nom in requeteObj)
            {
                Console.WriteLine(nom);
            }
            Console.WriteLine("\n*****************Utilisation d'une requete anonyme***************\n");

            var requeteAnonymus = from cli in listeClient
                                  where cli.age > 18
                                  orderby cli.age, cli.nom
                                  select new { cli.nom, cli.age };
            foreach (var obj in requeteAnonymus)
            {
                Console.WriteLine("{0} a {1} ans",obj.nom,obj.age);
            }

            Console.WriteLine("\n*****************Utilisation de requete avec jointure***************\n");
            List<Command> listeCommand = new List<Command>
            {
                new Command {identifiant=1,identifiantClient=1,prix=150.05M },
                new Command {identifiant=2,identifiantClient=2,prix=30M },
                new Command {identifiant=3,identifiantClient=1,prix=99.99M },
                new Command {identifiant=4,identifiantClient=1,prix=100M },
                new Command {identifiant=5,identifiantClient=3,prix=80M },
                new Command {identifiant=6,identifiantClient=3,prix=10M }
            };
            Console.WriteLine("Récupération des nom des client et le prix de la commande");
            var requeteJointure = from comm in listeCommand
                                  join clin in listeClient
                                  on comm.identifiantClient equals clin.identifiant
                                  select new { clin.nom, comm.prix };
            var requeteJointureV2 = from comm in listeCommand
                                  from clin in listeClient
                                  where comm.identifiantClient==clin.identifiant
                                  select new { clin.nom, comm.prix };
            foreach (var element in requeteJointure)
            {
                Console.WriteLine("Le client {0} a payé {1}", element.nom, element.prix);
            }

            Console.WriteLine("regrouper les commandes pour un client donné par identifiant ");
            var requetegroupee = from commande in listeCommand
                                 group commande by commande.identifiantClient;
            foreach (var item in requetegroupee)
            {
                Console.WriteLine("Le client : {0} a réalisé {1} commandes", item.Key,item.Count());
                foreach (Command comm in item)
                {
                    Console.WriteLine("\t Prix : {0}", comm.prix);
                }
            }

            Console.WriteLine("regrouper les commandes pour un client donné par nom ");
            var requeteGroupeeNom = from commande in listeCommand
                                    join clientC in listeClient
                                    on commande.identifiantClient equals clientC.identifiant
                                    group commande by new { commande.identifiantClient, clientC.nom };
            foreach (var element in requeteGroupeeNom)
            {
                Console.WriteLine("Le client {0} ({1}) a réalisé {2} commandes.", element.Key.nom,element.Key.identifiantClient, element.Count());
                foreach (Command com in element)
                {
                    Console.WriteLine("\t Prix : {0}", com.prix);
                }
            }

            Console.WriteLine("\n*****************Utilisation de requete avec INTO***************\n");
            var requeteInto = from commande in listeCommand
                              join clienT in listeClient
                              on commande.identifiantClient equals clienT.identifiant
                              group commande by new { commande.identifiantClient, clienT.nom }
                              into commandeGroup
                              select new
                              {
                                  commandeGroup.Key.identifiantClient,
                                  commandeGroup.Key.nom,
                                  nombreCommande = commandeGroup.Count()
                              };
            foreach (var item in requeteInto)
            {
                Console.WriteLine("Le client {0} ({1}) a réalisé {2} commandes.", item.nom,item.identifiantClient,item.nombreCommande);
            }

            Console.WriteLine("\n*****************Utilisation de requete avec des variables grace à LET***************\n");
            var requeteAvecVariable = from commande in listeCommand
                                      join clients in listeClient
                                      on commande.identifiantClient equals clients.identifiant
                                      group commande by new { commande.identifiantClient, clients.nom }
                                      into commandeDuGroupe
                                      let Total = commandeDuGroupe.Sum(c => c.prix)
                                      where Total > 50
                                      orderby Total
                                      select new
                                      {
                                          commandeDuGroupe.Key.identifiantClient,
                                          commandeDuGroupe.Key.nom,
                                          nombreDeCommandes = commandeDuGroupe.Count(),
                                          prixTotal = Total
                                      };
            foreach (var element in requeteAvecVariable)
            {
                Console.WriteLine("Le client {0} ({1}) a réalisé {2} commandes pour un total de {3}",
                    element.nom, element.identifiantClient, element.nombreDeCommandes, element.prixTotal);
            }

            Console.WriteLine("\n*****************Utilisation des méthodes d'extensions Linq***************\n");
            List<int> listeEntier = new List<int> { 4, 6, 1, 9, 5, 15, 8, 3 };
            IEnumerable<int> requeteFiltre = from nombre in listeEntier
                                             where nombre > 5
                                             select nombre;
            IEnumerable<int> requeteFiltreMieux = listeEntier.Where(chiffre => chiffre > 5);
            foreach (int i in requeteFiltreMieux)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Utilisation des expressions lambda");
            IEnumerable<Command> commandeFiltre = listeCommand.Where(com => com.prix > 100).Where(co => co.nombreArticles > 10).OrderBy(comM => comM.prix).ThenBy(c => c.date);

            Console.WriteLine("\n*****************Utilisation des mots clés : Sum et Average ****************\n");
            List<int> listeDEntier = new List<int> { 4, 6, 1, 9, 5, 15, 8, 3 };
            Console.WriteLine("somme: {0}", listeDEntier.Sum());
            Console.WriteLine("moyenne: {0}", listeDEntier.Average());

            Console.WriteLine("\n*****************Utilisation du mots clé : Take ****************\n");
            //permet de récupere les x premiers éléments d'une liste
            IEnumerable<Client> tri5Element = listeClient.OrderByDescending(client => client.age).Take(5);
            foreach (Client item in tri5Element)
            {
                Console.WriteLine("le client {0} a {1} ans",item.nom, item.age);
            }

            Console.WriteLine("\n*****************Utilisation du mots clé : Fisrt ****************\n");
            //permet de récupere les x premiers éléments d'une liste
            int FisrtElement = listeDEntier.Where(i => i > 5).First();
            Console.WriteLine("le premier élément de la liste : {0} est {1}", listeDEntier.GetType(),FisrtElement.ToString());
            Console.WriteLine("verifier si la liste est vide");
            Client nicolas = listeClient.FirstOrDefault(cli => cli.nom == "nicolas");
            if (nicolas==null)
            {
                Console.WriteLine("client non trouvé");
            }
            else
            {
                Console.WriteLine(nicolas.identifiant);
            }

            Console.WriteLine("\n*****************Utilisation du mots clé : Count ****************\n");
            //Count() permet d'obtenir le nombre d'éléments d'une source de données suivant un critère
            int nombreClientMajeur = listeClient.Count(client => client.age >= 18);
            Console.WriteLine("le nombre de clients majeur est : " + nombreClientMajeur);
            var requeteMajeur = listeClient.Where(cli => cli.age>=18).Select(cli => new { cli.age, cli.nom});
            foreach (var i in requeteMajeur)
            {
                Console.WriteLine("nom : "+ i.nom + " age : " + i.age);
            }

            Console.WriteLine("\n*****************Utilisation du mots clé : ToList() et ToArray()****************\n");
            //permet de forcer la requète a être mise dans une liste ou dans un tableau
            List<Client> listeMajeur = listeClient.OrderByDescending(cli => cli.age).Where(cli => cli.age >= 18).Take(5).ToList();
            Console.WriteLine("\t En liste :");
            foreach (Client item in listeMajeur)
            {
                Console.WriteLine("- " + item.nom + " -> " + item.age);
            }
            Console.WriteLine("\t En tableau :");
            Client[] tablClient = listeClient.OrderByDescending(cli => cli.age).Where(cli => cli.age >= 18).Take(5).ToArray();
            foreach (Client item in tablClient)
            {
                Console.WriteLine("- " + item.nom + " -> " + item.age);
            }

             Console.WriteLine("\n*****************Utilisation du mots clé : yield (exécution différée)****************\n");
            Console.WriteLine("méthode classique");
            List<int> listeDesEntier = new List<int> { 4, 6, 1, 9, 5, 15, 8, 3 };
            listeDesEntier.Sort();
            listeDesEntier.Add(7);
            foreach (int item in listeDesEntier)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("l'ajout de 7 se fait après le tri de la liste \n");
            Console.WriteLine("méthode avec execution différée");
            var requetDiff = listeDesEntier.OrderBy(e => e);
            listeDesEntier.Add(7);
            foreach (int item in requetDiff)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("la liste est trié malgré l'addition du 7 après");

            Console.ReadLine();
        }
    }
}
