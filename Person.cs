namespace knightmoves;

public class Person : Taxable{
   private string firstName;
   private string lastName;

   public Person(string firstName, string lastName){
      //Add your code here
      this.firstName = firstName;
      this.lastName = lastName;
   }
   public string FullName() : base(LookupTaxId())
   {
      return $"{firstName} {lastName}";
   }

   public string LookUpId(){
      return base.LookupTaxId(); //Add your code here
   }
}

public class Taxable{

   public string LookupTaxId(){
      return "testTaxId";
   }

}

