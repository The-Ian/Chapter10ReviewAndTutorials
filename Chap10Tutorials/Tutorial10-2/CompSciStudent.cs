using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial10_2
{
    class CompSciStudent : Student
    {
        private double Math_Hours = 20;
        private double CS_Hours = 40;
        private double Gen_Hours = 60;

        private string _academicTrack;

        public CompSciStudent(string name, string id, string track)
            : base(name, id)
        {
            _academicTrack = track;
        }

        public string AcademicTrack
        {
            get { return _academicTrack; }
            set { _academicTrack = value; }
        }

        public override double RequiredHours
        {
            get { return Math_Hours + CS_Hours + Gen_Hours; }
        }
    }
}
