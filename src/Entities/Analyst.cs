namespace ProjetoAMT.src.Entities
{
    public class Analyst
    {
        public Analyst(string Name, int Level, string Area){
            this.Name = Name;
            this.Level = Level;
            this.Area = Area;
        }

        public string Name;
        public int Level;
        public string Area;


        public override string ToString(){
            return this.Name + " " + this.Level + " " + this.Area;
        }

        public Analyst(){

        }

        public virtual string Target(){
            return this.Name + " tem meta individual de 70";
        }
    }
}