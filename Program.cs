using modul6_103022300043;

class Program
{
    static void Main()
    {
        SayaTubeVideo video1 = new SayaTubeVideo("Sherlock Holmes");
        SayaTubeVideo video2 = new SayaTubeVideo("Arcane");
        SayaTubeVideo video3 = new SayaTubeVideo("Persona 3 Movie");
        SayaTubeVideo video4 = new SayaTubeVideo("Detective Conan");
        SayaTubeVideo video5 = new SayaTubeVideo("Attack on Titan");
        SayaTubeVideo video6 = new SayaTubeVideo("Teror in Resonance");
        SayaTubeVideo video7 = new SayaTubeVideo("Upin & Ipin");
        SayaTubeVideo video8 = new SayaTubeVideo("Boboiboy");
        SayaTubeVideo video9 = new SayaTubeVideo("Dragon Ball");
        SayaTubeVideo video10 = new SayaTubeVideo("One punch man");
        //video.PrintVideoDetails();

        SayaTubeUser user = new SayaTubeUser("Mohammad Ilham Firdaus");
        user.AddVideo(video1);
        user.AddVideo(video2);
        user.AddVideo(video3);
        user.AddVideo(video4);
        user.AddVideo(video5);
        user.AddVideo(video6);
        user.AddVideo(video7);
        user.AddVideo(video8);
        user.AddVideo(video9);
        user.AddVideo(video10);
        user.PrintAllVideoPlayCount();
    }
}