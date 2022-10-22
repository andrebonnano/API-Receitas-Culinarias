
namespace Domain.Entities.Recipes
{
    public class PrepareGroup
    {
        public PrepareGroup()
        {

        }

        public PrepareGroup(string goupName)
        {
            GoupName = goupName;
        }

        public string GoupName { get; set; }
        public IList<string> Steps { get; set; }

        public void AddStep(string step)
        {
            Steps.Add(step);
        }
    }
}
