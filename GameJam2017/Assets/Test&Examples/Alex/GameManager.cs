using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CCC.Manager;

public class GameManager : Singleton<GameManager> {

    public ScenarioManager scenario;

	protected override void Awake () {
        base.Awake();
        MasterManager.Sync();

        scenario.Enrique.SetPersonne("Enrique", "Enrique est le PDG de l’entreprise.\n\nD’origine mexicaine, il a déménagé ici à un très jeune âge. Il est rapidement devenu un douchebag. Il passe une bonne partie de son temps dans en réunion ou dans la salle d’entrainement de l’édifice.", new Cell());
        scenario.Samantha.SetPersonne("Samantha", "Samantha est la secrétaire de l’entreprise.\n\nElle a rejoint l’entreprise au cours de la dernière année. Ses aptitudes professionnelles sont très peu développées, contrairement à sa poitrine. Ses deux excellentes qualités lui ont permis d’être engagé sans aucun problème.", new Cell());
        scenario.Steven.SetPersonne("Steven", "Steven est plus âgé de 2 minutes et 21 secondes que son frère Stephen qui travaille également dans l’entreprise.\n\nIl s’occupe du département des ressources humaines de l’entreprise et son bureau renferme l’ensemble des données confidentielles des employés.", new Cell());
        scenario.Stephen.SetPersonne("Stephen", "Stephen est quelqu’un d’extrêmement charismatique et est le frère cadet de Steven.\n\nSa dernière campagne publicitaire a permis de doubler le chiffre d’affaire de l’entreprise. Il adore aller discuter avec les autres employés et être le centre de l’attention.", new Cell());
        scenario.Justine.SetPersonne("Justine", "Justine est une excellente comptable, mais elle déteste la routine.\n\nDu moins, c’est la raison qu’elle vous donnera lorsque vous lui demanderez pourquoi elle ne reste jamais plus de 5 ans dans la même compagnie. Justement, son contrat de travail se termine aujourd’hui...", new Cell());
        scenario.Annushka.SetPersonne("Annushka", "Annushka est une jeune femme russe qui effectue un stage international au sein de l’entreprise.\n\nSon français laisse à désirer, mais elle arrive, du moins la plupart du temps, à se faire comprendre malgré tout. Annushka est une féministe très engagée et défend ardemment l’égalité des sexes en entreprise.", new Cell());
        scenario.Gary.SetPersonne("Gary", "Gary est l’informaticien de l’entreprise.\n\nAucun employé n’a déjà vu son visage, même pas le patron de l’entreprise, puisque Gary était déjà employé avant que Enrique devienne PDG. Des rumeurs supposent que le concierge a déjà aperçu brièvement la couleur de ses yeux, un soir de pleine lune lors de la dernière année bissextile.", new Cell());
        scenario.Gaetan.SetPersonne("Gaetan", "Gaétan est le concierge de l’édifice depuis près de 30 ans.\n\nD’origine musulmane, ses deux parents sont décédés il y a quelques années. Il passe la grande majorité de son temps dans les salles de bain de l’édifice ou dans son placard de conciergerie, ce qui explique ses comportements étranges.", new Cell());
        scenario.MonsieurX.SetPersonne("MonsieurX", "Whore", new Cell());
    }

    public static void EndGame(bool Win)
    {
        if (Win)
        {
            DelayManager.StopAll();
            Scenes.Load("GameWin");
        } else
        {
            DelayManager.StopAll();
            Scenes.Load("GameOver");
        }
    }
}
