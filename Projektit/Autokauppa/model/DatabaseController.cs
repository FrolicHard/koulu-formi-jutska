using System;
using System.Collections.Generic;
using System.Data.SqlClient;



namespace Autokauppa.model
{
    public class DatabaseController
    {
        private string yhteysTiedot;
        private SqlConnection dbYhteys = new SqlConnection();

        public DatabaseController()
        {
            yhteysTiedot = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=autokauppa;Integrated Security=True;Connect Timeout=5;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        public bool ConnectDatabase()
        {
            dbYhteys.ConnectionString = yhteysTiedot;

            try
            {
                dbYhteys.Open();
                Console.WriteLine("Tietokantayhteys on aktiivinen");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Virheilmoitukset:" + e.ToString());
                dbYhteys.Close();
                return false;
            }
        }

        public void DisconnectDatabase()
        {
            dbYhteys.Close();
        }

        public bool SaveAutoIntoDatabase(Auto newAuto)
        {
            try
            {
                using (dbYhteys)
                {
                    dbYhteys.ConnectionString = yhteysTiedot;
                    dbYhteys.Open();
                    string query = "INSERT INTO auto VALUES (@Hinta, @Rekisteri_paivamaara, @Moottorin_tilavuus, @Mittarinlukema, @AutonMerkkiID, @AutonMalliID, @VaritID, @PolttoaineID);";
                    SqlParameter[] Parameters =
                    {
                        new SqlParameter("@Hinta", newAuto.Hinta),
                        new SqlParameter("@Rekisteri_paivamaara", newAuto.Rekisteri_paivamaara),
                        new SqlParameter("@Moottorin_tilavuus", newAuto.Moottorin_tilavuus),
                        new SqlParameter("@Mittarinlukema", newAuto.Mittarilukema),
                        new SqlParameter("@AutonMerkkiID", newAuto.AutonMerkkiId),
                        new SqlParameter("@AutonMalliID", newAuto.AutonMalliId),
                        new SqlParameter("@VaritID", newAuto.VariId),
                        new SqlParameter("@PolttoaineID", newAuto.PolttoaineId)
                    };

                    SqlCommand command = new SqlCommand(query, dbYhteys);
                    command.Parameters.AddRange(Parameters);
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception e)
            {
                dbYhteys.Close();
                throw e;
            }

        }

        public Auto ChooseAutoMax()
        {
            try
            {
                using (dbYhteys)
                {
                    dbYhteys.ConnectionString = yhteysTiedot;
                    dbYhteys.Open();
                    string query = "SELECT TOP 1 * FROM auto ORDER BY ID DESC;";

                    using (SqlCommand command = new SqlCommand(query, dbYhteys))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Auto ValittuAuto = new Auto()
                                {
                                    Id = (int)reader["ID"],
                                    Hinta = (decimal)reader["Hinta"],
                                    Rekisteri_paivamaara = (DateTime)reader["Rekisteri_paivamaara"],
                                    Moottorin_tilavuus = (decimal)reader["Moottorin_tilavuus"],
                                    Mittarilukema = (int)reader["Mittarilukema"],
                                    AutonMerkkiId = (int)reader["AutonMerkkiID"],
                                    AutonMalliId = (int)reader["AutonMalliID"],
                                    VariId = (int)reader["VaritID"],
                                    PolttoaineId = (int)reader["PolttoaineID"]
                                };
                                return ValittuAuto;
                            }
                        }
                    }
                }
                dbYhteys.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Virheilmoitukset:" + e.ToString());
                return null;
            }
            return null;
        }

        public Auto ChooseAutoMin()
        {
            try
            {
                using (dbYhteys)
                {
                    dbYhteys.ConnectionString = yhteysTiedot;
                    dbYhteys.Open();
                    string query = "SELECT TOP 1 * FROM auto ORDER BY ID ASC;";

                    using (SqlCommand command = new SqlCommand(query, dbYhteys))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Auto ValittuAuto = new Auto()
                                {
                                    Id = (int)reader["ID"],
                                    Hinta = (decimal)reader["Hinta"],
                                    Rekisteri_paivamaara = (DateTime)reader["Rekisteri_paivamaara"],
                                    Moottorin_tilavuus = (decimal)reader["Moottorin_tilavuus"],
                                    Mittarilukema = (int)reader["Mittarilukema"],
                                    AutonMerkkiId = (int)reader["AutonMerkkiID"],
                                    AutonMalliId = (int)reader["AutonMalliID"],
                                    VariId = (int)reader["VaritID"],
                                    PolttoaineId = (int)reader["PolttoaineID"]
                                };
                                return ValittuAuto;
                            }
                        }
                    }
                }
                dbYhteys.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Virheilmoitukset:" + e.ToString());
                return null;
            }
            return null;
        }

        public Auto SelectNextAutoRow(int selectedID)
        {
            try
            {
                using (dbYhteys)
                {
                    dbYhteys.ConnectionString = yhteysTiedot;
                    dbYhteys.Open();
                    string query = "SELECT TOP 1 * FROM auto WHERE ID > " + selectedID + " ORDER BY ID ASC;";

                    using (SqlCommand command = new SqlCommand(query, dbYhteys))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Auto ValittuAuto = new Auto()
                                {
                                    Id = (int)reader["ID"],
                                    Hinta = (decimal)reader["Hinta"],
                                    Rekisteri_paivamaara = (DateTime)reader["Rekisteri_paivamaara"],
                                    Moottorin_tilavuus = (decimal)reader["Moottorin_tilavuus"],
                                    Mittarilukema = (int)reader["Mittarilukema"],
                                    AutonMerkkiId = (int)reader["AutonMerkkiID"],
                                    AutonMalliId = (int)reader["AutonMalliID"],
                                    VariId = (int)reader["VaritID"],
                                    PolttoaineId = (int)reader["PolttoaineID"]
                                };
                                return ValittuAuto;
                            }
                        }
                    }
                }
                dbYhteys.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Virheilmoitukset:" + e.ToString());
                return null;
            }
            return null;


        }

        public Auto SelectPreviousAutoRow(int selectedID)
        {
            try
            {
                using (dbYhteys)
                {
                    dbYhteys.ConnectionString = yhteysTiedot;
                    dbYhteys.Open();
                    string query = "SELECT TOP 1 * FROM auto WHERE ID < " + selectedID + " ORDER BY ID DESC;";

                    using (SqlCommand command = new SqlCommand(query, dbYhteys))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Auto ValittuAuto = new Auto()
                                {
                                    Id = (int)reader["ID"],
                                    Hinta = (decimal)reader["Hinta"],
                                    Rekisteri_paivamaara = (DateTime)reader["Rekisteri_paivamaara"],
                                    Moottorin_tilavuus = (decimal)reader["Moottorin_tilavuus"],
                                    Mittarilukema = (int)reader["Mittarilukema"],
                                    AutonMerkkiId = (int)reader["AutonMerkkiID"],
                                    AutonMalliId = (int)reader["AutonMalliID"],
                                    VariId = (int)reader["VaritID"],
                                    PolttoaineId = (int)reader["PolttoaineID"]
                                };
                                return ValittuAuto;
                            }
                        }
                    }
                }
                dbYhteys.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Virheilmoitukset:" + e.ToString());
                return null;
            }
            return null;
        }

        public List<AutonMerkki> GetAllAutoMakersFromDatabase()
        {
            List<AutonMerkki> autonMerkit = new List<AutonMerkki>();
            using (dbYhteys)
            {
                dbYhteys.ConnectionString = yhteysTiedot;
                dbYhteys.Open();
                string query = "SELECT * FROM AutonMerkki;";
                using (SqlCommand command = new SqlCommand(query, dbYhteys))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AutonMerkki uusiMerkki = new AutonMerkki
                            {
                                Id = (int)reader["ID"],
                                Merkki = reader["Merkki"].ToString()
                            };
                            autonMerkit.Add(uusiMerkki);
                        }
                    }
                }
            }
            dbYhteys.Close();
            return autonMerkit;
        }

        public List<AutonMalli> GetAutoModelsByMakerId(int makerId)
        {
            List<AutonMalli> autonMallit = new List<AutonMalli>();
            using (dbYhteys)
            {
                dbYhteys.ConnectionString = yhteysTiedot;
                dbYhteys.Open();

                string query = "SELECT * FROM AutonMallit WHERE AutonMerkkiID=@Id ;";
                SqlParameter par1 = new SqlParameter("@Id", makerId);

                using (SqlCommand command = new SqlCommand(query, dbYhteys))
                {
                    command.Parameters.Add(par1);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AutonMalli uusiMalli = new AutonMalli
                            {
                                Id = (int)reader["ID"],
                                Auton_mallin_nimi = reader["Auton_mallin_nimi"].ToString(),
                                AutonMerkkiId = (int)reader["AutonMerkkiID"]
                            };
                            autonMallit.Add(uusiMalli);
                        }
                    }
                }
            }
            dbYhteys.Close();
            return autonMallit;
        }

        public List<Polttoaine> GetAllFuelsFromDatabase()
        {
            List<Polttoaine> fuels = new List<Polttoaine>();
            using (dbYhteys)
            {
                dbYhteys.ConnectionString = yhteysTiedot;
                dbYhteys.Open();

                string query = "SELECT * From Polttoaine;";
                using (SqlCommand com = new SqlCommand(query, dbYhteys))
                {
                    using (SqlDataReader reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Polttoaine fuel = new Polttoaine
                            {
                                Id = (int)reader["ID"],
                                Polttoaineen_nimi = reader["Polttoaineen_nimi"].ToString()
                            };
                            fuels.Add(fuel);
                        }
                    }
                }
            }
            dbYhteys.Close();
            return fuels;
        }
        public List<Vari> GetColorsFromDatabase()
        {
            List<Vari> varit = new List<Vari>();
            using (dbYhteys)
            {
                dbYhteys.ConnectionString = yhteysTiedot;
                dbYhteys.Open();

                string query = "Select * From Varit;";
                using (SqlCommand com = new SqlCommand(query, dbYhteys))
                {
                    using (SqlDataReader reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Vari color = new Vari
                            {
                                Id = (int)reader["ID"],
                                Varin_nimi = reader["Varin_nimi"].ToString()
                            };
                            varit.Add(color);
                        }
                    }
                }
            }
            dbYhteys.Close();
            return varit;
        }
        public int DeleteRowFromDatabase(int selectedID)
        {
            try
            {
                using (dbYhteys)
                {
                    dbYhteys.ConnectionString = yhteysTiedot;
                    dbYhteys.Open();

                    SqlParameter par = new SqlParameter("id", selectedID);

                    string query = "DELETE FROM auto WHERE ID=@id;";
                    SqlCommand command = new SqlCommand(query, dbYhteys);
                    command.Parameters.Add(par);
                    int check = command.ExecuteNonQuery();
                    return check;
                }

            }
            catch (Exception e)
            {              
                dbYhteys.Close();
                return -1;
                throw e;
            }
        }
    }
}