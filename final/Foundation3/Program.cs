using System;

class Program
{
    static void Main(string[] args)
    {
       Address LectureAddress = new Address("Malecon 2000","Guayaquil","Guayas","Ecuador");
       Address ReceptionAddress = new Address("Lorenzo de garaicoa y 9 de Octubre","Guayaquil","Guayas","Ecuador");
       Address OutdoorAddress = new Address("Parque Samanes","Guayaquil","Guayas","Ecuador");

       Lecture Lecture = new Lecture("Lecture","100 años de soledad","Muy triste :(","21/07/2023","19:00PM",LectureAddress,"Dr. Julio Jaramillo",50);
       Reception Reception = new Reception("Reception","Reencuentro UPS","invitados todos los muchachos!!","15/09/2023","21:00PM",ReceptionAddress,"Tuki@gmail.com");
       Outdoor Outdoor = new Outdoor("Outdoor","Campamento JAS","Invitados todos los adultos de 18-30","14/09/2023","10:00AM",OutdoorAddress,"Sunny");
       
       Lecture.StandardDetails();
       Lecture.FullDetails();
       Lecture.ShortDescription();
       Console.WriteLine();
       
       Reception.StandardDetails();
       Reception.FullDetails();
       Reception.ShortDescription();
       Console.WriteLine();
       
       Outdoor.StandardDetails();
       Outdoor.FullDetails();
       Outdoor.ShortDescription();
       Console.WriteLine();
    }
}