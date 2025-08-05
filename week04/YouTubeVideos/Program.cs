using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Como programar con clases", "Miguel Luis", 1200);
        Video video2 = new Video("Mejores Jugadas de Messi", "Dabo", 800);
        Video video3 = new Video("How to coock hot dogs", "Ignacio Jofre", 14400);

        //Lets add comments for tose videos
        //video 1
        video1.TrackComment(new Comment("Miguel", "No me gusto, no entendi nada"));
        video1.TrackComment(new Comment("Tito", "Al principio no entendi, pero despues poco a poco entendia menos..."));
        video1.TrackComment(new Comment("Juan", "Clarida, sensilles, buenos ejemplos, didactica, todo eso le falto"));
        video1.TrackComment(new Comment("Ariel", "Me pasan el contexto por favor?"));
        video1.TrackComment(new Comment("Camilo", "Aca hay mucho talento, solo falta saber en que..."));

        //Video 2
        video2.TrackComment(new Comment("Mel", "Faaa un genio este Messi, no la puede pasar tan bien!"));
        video2.TrackComment(new Comment("Flor", "Increible, iban perdiendo y vino Messi y salieron campeones, entendes?"));
        video2.TrackComment(new Comment("Pilo", "Son veintidos locos corriendo detras de una pelota... Malisimo"));

        // Video 3
        video3.TrackComment(new Comment("Carlitos", "Nunca en mi vida vi que alguien cocinara Panchos con aceite..."));
        video3.TrackComment(new Comment("Damian", "Cada cuantos kilometros se le cambia el aceite?"));
        video3.TrackComment(new Comment("Felipe", "Que panchos, increible"));
        video3.TrackComment(new Comment("Tomas", "Se puede reemplazar el aceite por alguna otra cosa, como agua?"));

        // Save all in a list
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}