namespace InterfaceSegregation
{
    public class Ilustrator : IWorkTeamActivities, IIlustratorActivities
    {

        public void Plan() 
        {
            throw new ArgumentException();
        }

        public void Comunicate() 
        {
            throw new ArgumentException();
        }

        public void Design()
        {
            Console.WriteLine("I'm desing the logo");
        }
    }
}