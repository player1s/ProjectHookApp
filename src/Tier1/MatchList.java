package Tier1;

import java.util.ArrayList;

import com.sun.org.apache.xerces.internal.impl.xpath.regex.Match;
import com.sun.xml.internal.bind.v2.schemagen.xmlschema.List;

public class MatchList
{
   ArrayList<Match> MatchList = new ArrayList<>();

   public ArrayList<Match> getByGender(String gender)
   {
      ArrayList<Match> sortedMatches = new ArrayList<>();
      for (int i = 0; i < MatchList.size(); i++)
      {
         if (gender = match.getGender)
         {
            sortedMatches.add(MatchList.get(i));

         }

      }
      return sortedMatches;
   }

   public ArrayList<Match> getByAge(int age)
   {
      ArrayList<Match> sortedMatches = new ArrayList<>();
      for (int i = 0; i < MatchList.size(); i++)
      {
         if (age = match.getAge)
         {
            sortedMatches.add(MatchList.get(i));

         }

      }
      return sortedMatches;
   }

   public ArrayList<Match> getByDistance(int distance)
   {
      ArrayList<Match> sortedMatches = new ArrayList<>();
      for (int i = 0; i < MatchList.size(); i++)
      {
         if (distance = match.getGender)
         {
            sortedMatches.add(MatchList.get(i));

         }

      }
      return sortedMatches;
   }
}
