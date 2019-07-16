using System;

namespace CodeSamples.Common
{
    public class Student
    {
        public int studentid { get; set; }
        public string studentname { get; set; }
        public DateTime birthdate { get; set; }
        public byte[] photo { get; set; }

        public override string ToString()
        {
            return String.Format("studentid:{0} studentname:{1} birthdate:{2} photo:{3}", studentid, studentname, birthdate, photo==null? "null" : photo.Length.ToString());
        }
    }
}
