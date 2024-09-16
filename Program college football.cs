//Promt user for preferred level of enjoyment
//main

double enjoymentLevel= GetEnjoymentLevel();
string StadiumRecommendations= GetStadiumRecommendations(enjoymentLevel);
string GameRecommendations= GetGameRecommendations(enjoymentLevel)
DisplayStadiumRecommendations(enjoymentLevel, GameRecommendations);


//end main

static double GetEnjoymentLevel(){
    System.Console.Writeline("What is your prefered enjoyment level?");
    return double.Parse(Console.Readline());


}
Static string GetStadiumRecommendations(double enjoymentLevel){
}
    if(enjoymentLevel= Boring){
        return "Neyland Stadium vs. Kent State";

    }
     else if(enjoymentLevel= Average){
        return "Jordan-Hare Stadium vs. Kentucky";
    }
     else if(enjoymentLevel= Fun);{
        return "Tiger Stadium vs. Alabama";
     }
     else if (enjoymentLevel= Epic){
        return "Saban Feild at Bryant-Denny Stadium vs. Auburn";
    
     }
     
     else(
        return "that is an invalid input";

     )
     static void DisplayLetterGrade(double userGrade, string letterGrade)
     
     Console.Clear();
     System.Console.Writeline($"You inputed the enjoyment level as (enjoymentLevel)and your recommendation is (stadiumRecommendation")


