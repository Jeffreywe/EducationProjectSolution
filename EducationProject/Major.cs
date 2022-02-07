//namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationProject { // namespace of project
    public class Major { //classes
        private static int NextId { get; set; } = 1; // unique Id multiplier
        public int Id { get; set; } //properties
        public string Description { get; set; }
        public int MinSAT { get; set; }

        public Major(string description, int minSAT) { // constructor, sets the default values
            Id = NextId++; //sets Id to increment unique Id's starting at 1
            Description = description;
            MinSAT = minSAT;
        }

        

    }
}
