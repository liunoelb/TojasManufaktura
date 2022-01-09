using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TojasManufaktura
{
    public partial class FrmStatisztika : Form
    {
        public string ConnectionString { get; private set; }
        public FrmStatisztika(string connectionString)
        {
            ConnectionString = connectionString;
            InitializeComponent();
        }

        private void FrmStatisztika_Load(object sender, EventArgs e)
        {
            FillCB();
            FillDGV();
        }

        private void FillTB()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                if (dgv.Rows.Count != 0)
                {
                    var r = new SqlCommand(
                        "SELECT TOP 1 Tojas.Szin, SUM(Termeles.Mennyiseg) " +
                        "FROM Termeles, Nyul, Tojas " +
                        "WHERE Termeles.NyulId = Nyul.Id " +
                        "AND Termeles.TipusId = Tojas.Id " +
                       $"AND Nyul.Nev LIKE '{cbWorker.Text}' " +
                       $"AND MONTH(Termeles.Datum) LIKE {nudMonth.Value} " +
                        "GROUP BY Tojas.Szin " +
                        "ORDER BY SUM(Termeles.Mennyiseg) DESC;", conn)
                        .ExecuteReader();
                    while (r.Read())
                    {
                        tbMaxColor.Text = $"{r[0]} ({r[1]} db)";
                    }
                    r.Close();

                    r = new SqlCommand(
                        "SELECT SUM(Tojas.Suly * Termeles.Mennyiseg) " +
                        "FROM Termeles, Tojas, Nyul " +
                        "WHERE Termeles.TipusId = Tojas.Id " +
                        "AND Termeles.NyulId = Nyul.Id " +
                       $"AND Nyul.Nev LIKE '{cbWorker.Text}' " +
                       $"AND MONTH(Termeles.Datum) LIKE {nudMonth.Value}", conn)
                        .ExecuteReader();
                    while (r.Read())
                    {
                        tbSumWeight.Text = $"{(double)r.GetInt32(0) / 1000} Kg";
                    }
                }
                
            }
        }

        private void FillCB()
        {
            cbWorker.Items.Clear();
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                var r = new SqlCommand(
                    "SELECT Nev FROM Nyul;", conn)
                    .ExecuteReader();
                while (r.Read()) cbWorker.Items.Add(r[0]);
            }
        }

        private void FillDGV()
        {
            dgv.Rows.Clear();
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string nyulId = $"{cbWorker.SelectedIndex + 1}";
                string month = nudMonth.Value.ToString();
                var r = new SqlCommand(
                    "SELECT Termeles.Datum, Tojas.Szin, Termeles.Mennyiseg " +
                    "FROM Termeles, Tojas " +
                    "WHERE Termeles.TipusId = Tojas.Id " +
                   $"AND Termeles.NyulId LIKE {nyulId} " +
                   $"AND MONTH(Termeles.Datum) LIKE {month} " +
                    "ORDER BY Termeles.Datum;", conn)
                    .ExecuteReader();
                while (r.Read())
                {
                    dgv.Rows.Add(
                        r.GetDateTime(0).ToString("yyyy-MM-dd"),
                        r[1],
                        r[2] + " db");
                }

            }
        }

        private void CbWorker_SelectedIndexChanged(object sender, EventArgs e)
        { 
            FillDGV();
            FillTB();
        }
        private void NudMonth_ValueChanged(object sender, EventArgs e)
        { 
            FillDGV();
            FillTB();
        }
    }
}
