using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title = "Jesus calms the storm";
        video1._author = "GospelDaily";
        video1._length = 10;
        
        Comment comment_11 = new Comment();
        comment_11._name = "Peter32";
        comment_11._text = "Amen";
        
        Comment comment_12 = new Comment();
        comment_12._name = "Cat29";
        comment_12._text = "How great is our Lord.";
        
        Comment comment_13 = new Comment();
        comment_13._name = "Liberion1";
        comment_13._text = "My favorite scripture Mark 4:39 <3";

        video1._Comments.Add(comment_11);
        video1._Comments.Add(comment_12);
        video1._Comments.Add(comment_13);
        video1.DisplayInfo();
        video1.CommentCount();
        
        Video video2 = new Video();
        video2._title = "Summer vacation mix";
        video2._author = "MusicBando";
        video2._length = 30;
        
        Comment comment_21 = new Comment();
        comment_21._name = "CSwent";
        comment_21._text = "Love your music!!!";
        
        Comment comment_22 = new Comment();
        comment_22._name = "Garygg";
        comment_22._text = "Nice ;D";
        
        Comment comment_23 = new Comment();
        comment_23._name = "VictoriaH";
        comment_23._text = "im a huge fan!!!!";
        
        video2._Comments.Add(comment_21);
        video2._Comments.Add(comment_22);
        video2._Comments.Add(comment_23);
        video2.DisplayInfo();
        video2.CommentCount();
        
        Video video3 = new Video();
        video3._title = "SSB Ultimate Finals 2020";
        video3._author = "Tuk1_O";
        video3._length = 15;

        Comment comment_31 = new Comment();
        comment_31._name = "SevasCB";
        comment_31._text = "Bet Nero gonna win";
        
        Comment comment_32 = new Comment();
        comment_32._name = "M&D<3U";
        comment_32._text = "M2king > Mango";
        
        Comment comment_33 = new Comment();
        comment_33._name = "Trix";
        comment_33._text = "Let's GO!!!!!!!!!!!";

        video3._Comments.Add(comment_31);
        video3._Comments.Add(comment_32);
        video3._Comments.Add(comment_33);
        video3.DisplayInfo();
        video3.CommentCount();
     
    }
}