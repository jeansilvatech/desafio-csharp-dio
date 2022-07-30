
namespace csharp_projeto.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType){

           this.Name = Name;
           this.Level = Level;
           this.HeroType = HeroType;
        }
        
       public override string Attack(){

        return this.Name + " lançou black magic!";

       }
       public string Attack(int Bonus){

        if(Bonus > 6){
            return this.Name + " lançou black magic super efetiva com bônus de ataque de " +Bonus;
        } 
        else{
           return this.Name + " lançou black magic com força fraca com bônus de " +Bonus; 
        }

       }
    }
}