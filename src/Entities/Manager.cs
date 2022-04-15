namespace ProjetoAMT.src.Entities
{
    public class Manager : Analyst
    {

        public Manager(string Name, int Level, string Area)
        {
            this.Name = Name;
            this.Level = Level;
            this.Area = Area;
        }
         public override string Target(){
            return this.Name + " tem meta individual de 60";
        }

        public string Target(int Bonus){

            if (Bonus >= 10){
                return this.Name + " tem meta individual de 60 e meta de equipe de " + Bonus*4;
            } else {
                return this.Name + " tem meta individual de 60 e meta de equipe de " + Bonus*2;
            }
            
        }
    }
}