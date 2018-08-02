namespace abstract2
{
     public class WorkerBee : Employee
    {
        public WorkerBee(string name): base(name)
        {

        }
        public override int GetSalary()
        {
            return 1000000;
        }

        
    }
}
