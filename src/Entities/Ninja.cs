
namespace csharp_projeto.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType){

           this.Name = Name;
           this.Level = Level;
           this.HeroType = HeroType;
        }
       public override string Attack(){

        return this.Name + " lançou ataque";

       }
       public string Attack(int Bonus){

        if(Bonus > 6){
            return this.Name + " lançou ataque super efetivo com bônus de ataque de " +Bonus;
        } 
        else{
           return this.Name + " lançou um ataque com força fraca com bônus de " +Bonus; 
        }

       }
    }
}