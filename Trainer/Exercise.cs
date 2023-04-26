using System.ComponentModel;

namespace Trainer
{

    public class Exercise
    {
        public int id { get; set; }
        public string type { get; set; }
        public string value { get; set; }

        public Exercise(string mode, string value)
        {
            this.type = mode;
            this.value = value;
        }

        public Exercise()
        {

        }
    }

}
