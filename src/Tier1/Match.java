package Tier1;

import java.math.MathContext;

public class Match
{
   private Profile matchWith;

   public Match(Profile profile)
   {
      this.matchWith = profile;
   }

   public String getGender()
   {
      return matchWith.getGender();
   }
   // public int getDistance() {
   // int responseFromT2;
   // return responseFromT2;
   // not right now
   // send 2 profiles to tier2

   public int getAge() {
      return matchWith.getAge();
   }
   
   
}
