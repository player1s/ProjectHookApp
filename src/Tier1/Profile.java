package Tier1;

public class Profile
{
   private String name;
   private int age;
   private String gender;
   private String description;
   private double xcoordinate;
   private double ycoordinate;

   public Profile(String name, int age, String gender, String description,double xcoordinate,double ycoordinate)
   {
      this.name = name;
      this.age = age;
      this.gender = gender;
      this.description = description;
      this.xcoordinate=xcoordinate;
      this.ycoordinate=ycoordinate;

   }

   public double getXcoordinate()
   {
      return xcoordinate;
   }

   public void setXcoordinate(double xcoordinate)
   {
      this.xcoordinate = xcoordinate;
   }

   public double getYcoordinate()
   {
      return ycoordinate;
   }

   public void setYcoordinate(double ycoordinate)
   {
      this.ycoordinate = ycoordinate;
   }

   public String getName()
   {
      return name;
   }

   public void setName(String name)
   {
      this.name = name;
   }

   public int getAge()
   {
      return age;
   }

   public void setAge(int age)
   {
      this.age = age;
   }

   public String getGender()
   {
      return gender;
   }

   public void setGender(String gender)
   {
      this.gender = gender;
   }

   public String getDescription()
   {
      return description;
   }

   public void setDescription(String description)
   {
      this.description = description;
   }

   @Override
   public String toString()
   {
      return "Profile [name=" + name + ", age=" + age + ", gender=" + gender
            + ", description=" + description + ", xcoordinate=" + xcoordinate
            + ", ycoordinate=" + ycoordinate + "]";
   }

 

}
