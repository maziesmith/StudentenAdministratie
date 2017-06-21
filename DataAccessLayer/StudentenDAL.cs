using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Classes.cs;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class StudentenDAL
    {
        public static List<Studenten> StudentenLijst()
        {

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-698P2MHO\SQLEXPRESS;Initial Catalog=StudentenAdministratie;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT studentID, voorNaam, achterNaam FROM Studenten", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Studenten> klas = new List<Studenten>();
           

            try
            {
                while(reader.Read())
                {
                    Studenten student = new Studenten();
                    if (!reader.IsDBNull(0)) student.studentID = reader.GetInt32(0);
                    if (!reader.IsDBNull(1)) student.voorNaam = reader.GetString(1);
                    if (!reader.IsDBNull(2)) student.achterNaam = reader.GetString(2);
                    klas.Add(student);
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return klas;
        }

        public static string GetLastName(Studenten student)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-698P2MHO\SQLEXPRESS;Initial Catalog=StudentenAdministratie;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT achterNaam FROM Studenten WHERE studentID = @studentID", con);
            cmd.Parameters.AddWithValue("@studentID", student.studentID);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while(reader.Read())
                {
                    if (!reader.IsDBNull(0)) student.achterNaam = reader.GetString(0);
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }        
            return student.achterNaam;
        }

        public static string GetFirstName(Studenten student)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-698P2MHO\SQLEXPRESS;Initial Catalog=StudentenAdministratie;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT voorNaam FROM Studenten WHERE studentID = @studentID", con);
            cmd.Parameters.AddWithValue("@studentID", student.studentID);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    if (!reader.IsDBNull(0)) student.voorNaam = reader.GetString(0);
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
            return student.voorNaam;
        }

        public static void AddStudentToDatabase(Studenten student)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-698P2MHO\SQLEXPRESS;Initial Catalog=StudentenAdministratie;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO Studenten (voorNaam, achterNaam) VALUES (@voorNaam, @achterNaam)", con);
            cmd.Parameters.AddWithValue("@voorNaam", student.voorNaam);
            cmd.Parameters.AddWithValue("@achterNaam", student.achterNaam);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static List<Vakken> GetStudent(Studenten student)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-698P2MHO\SQLEXPRESS;Initial Catalog=StudentenAdministratie;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Vakken JOIN StudentVak ON StudentVak.vakID = Vakken.vakID WHERE StudentVak.studentID = @studentID", con);
            cmd.Parameters.AddWithValue("@studentID", student.studentID);
            List<Vakken> vakken = new List<Vakken>();
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while(reader.Read())
                {
                    Vakken vak = new Vakken();
                    if (!reader.IsDBNull(0)) vak.vakID = reader.GetInt32(0);
                    if (!reader.IsDBNull(1)) vak.vakNaam = reader.GetString(1);
                    vakken.Add(vak);
                    
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return vakken;
            
        }
    }
}