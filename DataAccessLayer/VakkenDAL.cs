using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Classes.cs;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public class VakkenDAL
    {
        public static List<Vakken> VakkenLijst()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-698P2MHO\SQLEXPRESS;Initial Catalog=StudentenAdministratie;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Vakken", con);
            List<Vakken> vakkenlijst = new List<Vakken>();
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Vakken vak = new Vakken();
                    if (!reader.IsDBNull(0)) vak.vakID = reader.GetInt32(0);
                    if (!reader.IsDBNull(1)) vak.vakNaam = reader.GetString(1);
                    vakkenlijst.Add(vak);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return vakkenlijst;

        }

        public static void AddVakToDatabase(string vaknaam)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-698P2MHO\SQLEXPRESS;Initial Catalog=StudentenAdministratie;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO Vakken (vakNaam) VALUES (@vakNaam)", con);
            cmd.Parameters.AddWithValue("@vakNaam", vaknaam);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public static void UpdateVak(Vakken vak)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-698P2MHO\SQLEXPRESS;Initial Catalog=StudentenAdministratie;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("UPDATE Vakken SET vakNaam = @vakNaam WHERE vakID = @vakID", con);
            cmd.Parameters.AddWithValue("@vakNaam", vak.vakNaam);
            cmd.Parameters.AddWithValue("@vakID", vak.vakID);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public static List<Studenten> ShowStudentenVanVak(Vakken vak)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-698P2MHO\SQLEXPRESS;Initial Catalog=StudentenAdministratie;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT Studenten.studentID, voorNaam, achternaam FROM Studenten JOIN StudentVak ON StudentVak.studentID = Studenten.studentID WHERE StudentVak.vakID = @vakID", con);
            cmd.Parameters.AddWithValue("@vakID", vak.vakID);
            List<Studenten> students = new List<Studenten>();
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    Studenten student = new Studenten();
                    if (!reader.IsDBNull(0)) student.studentID = reader.GetInt32(0);
                    if (!reader.IsDBNull(1)) student.voorNaam = reader.GetString(1);
                    if (!reader.IsDBNull(2)) student.achterNaam = reader.GetString(2);
                    students.Add(student);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return students;

        }

        public static void VoegVakToeAanStudent(Vakken vak, Studenten student)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-698P2MHO\SQLEXPRESS;Initial Catalog=StudentenAdministratie;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO StudentVak VALUES (@studentID, @vakID)", con);
            cmd.Parameters.AddWithValue("@studentID", student.studentID);
            cmd.Parameters.AddWithValue("@vakID", vak.vakID);
            try
            {
                con.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }
    }
}