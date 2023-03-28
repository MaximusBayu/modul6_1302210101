// See https://aka.ms/new-console-template for more information

using modul6_1302210101;

SayaTubeUser max = new SayaTubeUser("MAX");

SayaTubeVideo video = new SayaTubeVideo("REVIEW FILM DOG OLEH MAX");

for (int i = 0; i < 1000; i++) { 
    video.IncreasePlayCount(1000000000);
}
SayaTubeVideo video2 = new SayaTubeVideo("REVIEW FILM DOG2 OLEH MAX");
SayaTubeVideo video3 = new SayaTubeVideo("REVIEW FILM DOG3 OLEH MAX");
SayaTubeVideo video4 = new SayaTubeVideo("REVIEW FILM DOG4 OLEH MAX");
SayaTubeVideo video5 = new SayaTubeVideo("REVIEW FILM DOG5 OLEH MAX");
SayaTubeVideo video6 = new SayaTubeVideo("REVIEW FILM DOG6 OLEH MAX");
SayaTubeVideo video7 = new SayaTubeVideo("REVIEW FILM DOG7 OLEH MAX");
SayaTubeVideo video8 = new SayaTubeVideo("REVIEW FILM DOG8 OLEH MAX");
SayaTubeVideo video9 = new SayaTubeVideo("REVIEW FILM DOG9 OLEH MAX");
SayaTubeVideo video10 = new SayaTubeVideo("REVIEW FILM DOG10 OLEH MAX");

max.AddVideo(video);
max.AddVideo(video2);
max.AddVideo(video3);
max.AddVideo(video4);
max.AddVideo(video5);
max.AddVideo(video6);
max.AddVideo(video7);
max.AddVideo(video8);
max.AddVideo(video9);
max.AddVideo(video10);

max.PrintAllVideocount();