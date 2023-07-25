namespace stagiareMediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMediator mediator = new MissionHandicap("Beatrice Guy");
            Societe capGemini = new (mediator,"CapGemini","Serge Kampf",1967,"Aiman Esat");
            Stagiaire rodolphe = new (mediator,"Bounatirou","Rodolphe","cV de Rodolphhe\nJe\nsuis\nPILOTE");
            Stagiaire gatien = new (mediator, "Facqueur", "Gatien", "cV de Gatien\nJe\nsuis\nPILOTE");
            Stagiaire angelo = new (mediator, "Conju", "Angelo", "cV de Angelo\naaaaaaaaaaaaa\naaaaaaaaaaa\naaaaaaaa");
            Stagiaire johnny = new (mediator, "Charvet", "Johnny", "cV de Johnny\nbbbbbbbbbbbbbb\nbbbbbbbbbbb\nbbbbbbbbbb");
            Stagiaire nicolas = new (mediator, "Ferrand", "Nicolas", "cV de Nicolas\nccccccccccccc\ncccccccccccccc\nccccccc");

            capGemini.DemanderCVs();
            Console.WriteLine(capGemini.InfoPublish()+"\n\n"+capGemini.CvPublish());
        }
    }
}