namespace stagiareMediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Création du mediator
            IMediator mediator = new ConcreteMediator("Mission Handicap");

            //Création dee la societé
            Societe capGemini = new (mediator,"CapGemini","Serge Kampf",1967,"Aiman Esat");

            //Création des Stagiaire
            Stagiaire rodolphe = new (mediator,"Bounatirou","Rodolphe","cV de Rodolphhe\nJe\nsuis\nPILOTE");
            Stagiaire gatien = new (mediator, "Facqueur", "Gatien", "cV de Gatien\nJe\nsuis\nPILOTE");
            Stagiaire angelo = new (mediator, "Rognone", "Gerard", "cV de Angelo\nje\nsuis\nMUSICIEN");
            Stagiaire johnny = new (mediator, "Charvet", "Johnny", "cV de Johnny\nje\nsuis\nBATMAN");
            Stagiaire nicolas = new (mediator, "Ferrand", "Nicolas", "cV de Nicolas\nje\nsuis\nBILINGUE");

            //Apelle de la fonction DemanderCVs de capGemini
            capGemini.DemanderCVs();
            //Affichage des information de Cap Gemini et la liste des CV qu'elle a recu
            Console.WriteLine(capGemini.InfoPublish()+"\n\n"+capGemini.CvPublish()); 
        }
    }
}