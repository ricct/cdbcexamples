using Cdbc.Common.Data.Type;
using Cdbc.Data.Client;
using CodeSamples.Common;
using Dapper;
using System;
using System.Collections.Generic;

namespace CodeSamples.Oracle
{
    /*
     * 
      CREATE TABLE "DEMOCODE"."STUDENT" 
   (	"STUDENTID" NUMBER(9,0) NOT NULL ENABLE, 
	"STUDENTNAME" VARCHAR2(80 BYTE), 
	"BIRTHDATE" DATE, 
	"PHOTO" BLOB, 
	 CONSTRAINT "STUDENT_PK" PRIMARY KEY ("STUDENTID")
     )

   */
    public class OracleDapperSample
    {
        private const DatabaseProductType databaseProductType = DatabaseProductType.Oracle;
        public static void Dapper_Execute_Sample()
        {
            Console.WriteLine(String.Format("{0} Dapper_Execute_Sample", databaseProductType.ToString()));
            Console.WriteLine("Start");

            CdbcConnection con = UtilCommon.getConnection(databaseProductType);
            string sqlInsert = @"INSERT INTO student(studentid, studentname, birthdate, photo) VALUES (:studentid, :studentname, :birthdate, :photo)";
            string sqlUpdate = @"UPDATE student SET studentname=:studentname, birthdate=:birthdate, photo=:photo WHERE studentid=:studentid";
            string sqlDelete = @"DELETE FROM student WHERE studentid=:studentid";
            string sqlSelect = @"SELECT studentid, studentname, birthdate, photo FROM student WHERE studentid=:studentid";

            int studentid1 = new System.Random(DateTime.Now.Millisecond).Next(1000);
            byte[] photo1 =null ;
            //You can use the following code to insert the photo.
            //byte[] photo1=System.IO.File.ReadAllBytes(@"photo file path");

            var student1 = new Student() { studentid = studentid1, studentname = "Tom", birthdate = new DateTime(2004, 11, 24), photo = photo1 };

            try
            {
                //Insert
                int i = con.Execute(sqlInsert, student1);

                Console.WriteLine("--------------------------");
                Console.WriteLine("Sql : " + sqlInsert);
                Console.WriteLine("student parameter: " + student1.ToString());
                Console.WriteLine(String.Format("{0} Line(s) inserted.", i));

                //Insert result
                var studentDb = con.QuerySingle<Student>(sqlSelect, student1);
                Console.WriteLine("student inserted: " + studentDb.ToString());

                //update 
                //We will change the student's name and birthday then update database.
                student1.studentname = "Tom2";
                student1.birthdate = new DateTime(2004, 6, 11);
                i = con.Execute(sqlUpdate, student1);
                Console.WriteLine(String.Format("{0} Line(s) updated.", i));

                //update result
                studentDb = con.QuerySingle<Student>(sqlSelect, student1);
                Console.WriteLine("student updated: " + studentDb.ToString());

                //delete 
                i = con.Execute(sqlDelete, student1);
                Console.WriteLine(String.Format("{0} Line(s) deleted.", i));

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine("End");
        }


        public static void Dapper_ExecuteMany_Sample()
        {

            Console.WriteLine(String.Format("{0} Dapper_ExecuteMany_Sample", databaseProductType.ToString()));
            Console.WriteLine("Start");

            CdbcConnection con = UtilCommon.getConnection(databaseProductType);
            string sqlInsert = @"INSERT INTO student(studentid, studentname, birthdate, photo) VALUES (:studentid, :studentname, :birthdate, :photo)";
            string sqlUpdate = @"UPDATE student SET studentname=:studentname, birthdate=:birthdate, photo=:photo WHERE studentid=:studentid";
            string sqlDelete = @"DELETE FROM student WHERE studentid in (:studentid1,:studentid2)";
            string sqlSelect = @"SELECT studentid, studentname, birthdate, photo FROM student ORDER BY studentid";

            int studentid1 = new System.Random(DateTime.Now.Millisecond).Next(1000);
            int studentid2 = studentid1 + 1;
            byte[] photo1 = null;
            //You can use the following code to insert the photo.
            //byte[] photo1=System.IO.File.ReadAllBytes(@"photo file path");

            var student1 = new Student() { studentid = studentid1, studentname = "Tom Inserted", birthdate = new DateTime(2004, 1, 21), photo = photo1 };
            var student2 = new Student() { studentid = studentid2, studentname = "Jack Inserted", birthdate = new DateTime(2004, 2, 22), photo = photo1 };

            try
            {
                //Insert
                int i = con.Execute(sqlInsert,
                       new[]
                        {student1,
                         student2
                        }
                       );

                Console.WriteLine("--------------------------");
                Console.WriteLine("Insert Sql : " + sqlInsert);
                Console.WriteLine("student1 parameter: " + student1.ToString());
                Console.WriteLine("student2 parameter: " + student2.ToString());
                Console.WriteLine(String.Format("{0} Line(s) inserted.", i));

                List<Student>  studentDb = (List<Student>)con.Query<Student>(sqlSelect);
                foreach (Student student in studentDb)
                {
                    Console.WriteLine("Student inserted result: " + student.ToString());
                }

                //update 
                //We will change the student's name and birthday then update database.
                student1.studentname = "Tom Updated";
                student1.birthdate = new DateTime(2004, 3, 21);

                student2.studentname = "Jack Updated";
                student2.birthdate = new DateTime(2004, 4, 21);

                i = con.Execute(sqlUpdate,
                      new[]
                       {student1,
                         student2
                       }
                      );

                Console.WriteLine("--------------------------");
                Console.WriteLine("Update Sql : " + sqlUpdate);
                Console.WriteLine("student1 parameter: " + student1.ToString());
                Console.WriteLine("student2 parameter: " + student2.ToString());
                Console.WriteLine(String.Format("{0} Line(s) updated.", i));

                //update result
                studentDb = (List<Student>)con.Query<Student>(sqlSelect);
                foreach (Student student in studentDb)
                {
                    Console.WriteLine("Student updated result: " + student.ToString());
                }

                //delete 
                i = con.Execute(sqlDelete, new { studentid1 = student1.studentid, studentid2 = student2.studentid });

                Console.WriteLine("--------------------------");
                Console.WriteLine("Delete Sql : " + sqlDelete);
                Console.WriteLine(String.Format("{0} Line(s) deleted.", i));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine("End");
        }
    }
}
