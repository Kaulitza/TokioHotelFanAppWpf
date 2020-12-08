﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;
using TokioHotelFanApp.Models;



namespace TokioHotelFanApp.DataLayer.Data
{

    public static class GameSeedData
    {
        public static ObservableCollection<Albums> AlbumObjects()
        {

            //string absolutePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            //string _filePath = Path.GetFullPath(absolutePath + "..\\..\\..\\DataLayer\\album.json");
            //int i = 0;
            //Albums albums;
            //string json;
            //// deserialize JSON directly from a file
            //using (StreamReader r = new StreamReader(_filePath))
            //{
            //    json = r.ReadToEnd();
            //    albums = JsonConvert.DeserializeObject<Albums>(json);
            //}
            //dynamic alb = JsonConvert.DeserializeObject(json);
            //foreach (var item in alb)
            //{
            //    Console.WriteLine("{0} {1}", item.Album_Name, item.Album_Id);
            //}

            return new ObservableCollection<Albums>()
            {
                new Albums("1","Schrei","2005-09-19","13", "4","1500000","Universal Germany",
                    Album1Songs()
                ),
                new Albums("2","Zimmer 483","2007-02-23","13", "4","1000000","Universal Music",Album2Songs()),
                new Albums("3","Scream","2007-06-01","12", "5","2500000","Interscope, Cherrytree",Album3Songs()),
                new Albums("4","Humanoid","2009-10-02","12", "2","500000","Cherrytree",Album4Songs()),
                new Albums("5","Kings Of Suburbia","2014-10-03","11", "3","200000","De-Code",Album5Songs()),
                new Albums("6","Dream Machine","2017-03-03", "10","4","100000","Devilish",Album6Songs())
            };


            //return new ObservableCollection<Albums>()
            //{
            //    new Albums("1","Schrei","2005-09-19","13", "4","1500000","Universal Germany"                ),
            //    new Albums("2","Zimmer 483","2007-02-23","13", "4","1000000","Universal Music"),
            //    new Albums("3","Scream","2007-06-01","12", "5","2500000","Interscope, Cherrytree"),
            //    new Albums("4","Humanoid","2009-10-02","12", "2","500000","Cherrytree"),
            //    new Albums("5","Kings Of Suburbia","2014-10-03","11", "3","200000","De-Code"),
            //    new Albums("6","Dream Machine","2017-03-03", "10","4","100000","Devilish")
            //};
        }

        public static Users getCurrentUser(string id)
        {
            string idss = id.ToString();
            Users users = new Users();
            try
            {
                string MyConString = "Server=127.0.0.1;Port=3306;Uid=root;Pwd=;Database=tokiohotel;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "select * from users where id=@ids";
                command.Parameters.AddWithValue("@id", idss);
                connection.Open();
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    users.UserName = Reader[1].ToString();
                    users.Pasword = Reader[2].ToString();
                    users.UserEmail = Reader[3].ToString();
                }
                connection.Close();
                return users;

            }
            catch (Exception e)
            {
                MessageBox.Show("DB Error");
            }

            return users;
        }

        public static ObservableCollection<Songs> Album1Songs()
        {


            return new ObservableCollection<Songs>()
            {

                new Songs( "Sch1",
                            "Schrei",
                             "1","David Jost, Dave Roth",
                            "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "Sch2",
                            "Durch den Monsun",
                            "1",
                            "Bill Kaulitz, Roth, Benzner, Jost, Hoffmann",
                            "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "Sch3",
                             "Leb die Sekunde",
                             "1",
                             "Bill Kaulitz, Roth, Benzner, Jost",
                             "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "Sch4",
                            "Rette Mich",
                            "1",
                             "Roth, Benzner, Jost",
                            "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "Sch5",
                               "Freunde Bleiben",
                                "1",
                                "Roth, Benzner, Jost",
                                "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "Sch6",
                                "Ich bin nich'ich",
                                 "1",
                                 "Roth, Benzner, Jost",
                                 "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "Sch7",
                                "Wenn nichts mehr geht",
                                 "1",
                                "Bill Kaulitz, Roth, Benzner, Jost",
                                 "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "Sch8",
                             "Laß uns hier raus",
                              "1",
                               "Roth, Benzner, Jost, Tokio Hotel",
                                "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                 new Songs(  "Sch9",
                                 "Gegen meinen Willen",
                                "1",
                                 "Tokio Hotel, Roth, Benzner, Jost",
                                "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                  new Songs(  "Sch10",
                                "Jung und nicht mehr jugendfrei",
                                "1",
                                 "Tokio Hotel, Roth, Jost",
                                 "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                   new Songs(  "Sch11",
                                 "Der letzte Tag",
                                "1",
                                  "Roth, Benzner, Jost, Bill Kaulitz",
                                  "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                    new Songs(  "Sch12",
                                    "Unendlichkeit",
                                    "1",
                                    "Tokio Hotel",
                                     "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                     new Songs(  "Sch13",
                                    "Monsun o Koete",
                                     "1",
                                     "Tokio Hotel",
                                     "Peter Hoffmann, Patrick Benzner, Roth, Jost"),

            };
        }

        public static ObservableCollection<Songs> Album2Songs()
        {


            return new ObservableCollection<Songs>()
            {

                new Songs( "Z1",
                             "Übers Ende der Wel",
                                "2",
                                "David Jost, Dave Roth, Patrick Benzner, Peter Hoffmann, Bill Kaulitz, Tom Kaulitz",
                                "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "Z2",
                             "Totgeliebt",
                             "2",
                                "Bill Kaulitz, Tom Kaulitz, Georg Listing, Gustav Schafer, Roth, Benzner, Jost, Hoffmann",
                                "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "Z3",
                            "Spring Nicht",
                             "2",
                             "Bill Kaulitz, Tom Kaulitz, Roth, Benzner, Jost, Hoffmann",
                             "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "Z4",
                            "Heilig",
                            "2",
                             "Roth, Benzner, Jost, Hoffmann, Bill Kaulitz",
                               "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "Z5",
                             "Wo sind eure Hände",
                                "2",
                                "Roth, Benzner, Jost, Hoffmann, Bill Kaulitz, Tom Kaulitz, Gustav Schafer, Georg Listing ",
                                "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "Z6",
                                "Stich ins Glück",
                                 "2",
                                "Roth, Benzner, Jost, Hoffmann, Bill Kaulitz, Tom Kaulitz",
                                "Peter Hoffmann, Patrick Benzner, Roth, Jost"),

                new Songs(  "Z7",
                             "Ich brech aus",
                            "2",
                            "Roth, Benzner, Jost, Hoffmann, Bill Kaulitz, Tom Kaulitz, Georg Listing, Gustav Schafer",
                            "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "Z8",
                            "Reden",
                             "2",
                            "Bill Kaulitz, Roth, Benzner, Jost, Hoffmann, Bill Kaulitz, Tom Kaulitz",
                            "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "Z9",
                             "Nach Dir Kommt Nichts",
                              "2",
                                "Roth, Benzner, Jost, Hoffmann, Tom Kaulitz, Bill Kaulitz",
                                "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "Z10",
                               "Wir Sterben Niemals Aus",
                                "2",
                                 "Bill Kaulitz, Tom Kaulitz",
                                "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "Z11",
                            "Vergessene Kinder",
                            "2",
                            "Roth, Benzner, Jost, Hoffmann, Bill Kaulitz, Tom Kaulitz",
                             "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "Z12",
                            "An Deiner Seite",
                             "2",
                            "Roth, Benzner, Jost, Hoffmann, Bill Kaulitz",
                            "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "Z13",
                            "In Die Nacht",
                             "2",
                             "Bill Kaulitz",
                            "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
            };
        }

        public static ObservableCollection<Songs> Album3Songs()
        {


            return new ObservableCollection<Songs>()
            {

                new Songs( "S1",
             "Scream",
            "3",
             "Bill Kaulitz, Roth, Benzner, Jost, Hoffmann",
             "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "S2",
              "Ready, Set, Go",
             "3",
              "Bill Kaulitz, Roth, Benzner, Jost, Hoffmann",
              "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "S3",
              "Monsoon",
             "3",
             "Bill Kaulitz, Roth, Benzner, Jost",
              "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "S4",
             "Love Is Dead",
              "3",
              "Bill Kaulitz, Roth, Benzner, Jost, Hoffmann",
             "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "S5",
             "Don't Jump",
              "3",
             "Bill Kaulitz, Roth, Benzner, Jost, Hoffmann",
              "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "S6",
             "On The Edge",
              "3",
              "Bill Kaulitz, Roth, Benzner, Jost, Hoffmann",
              "Peter Hoffmann, Patrick Benzner, Roth, Jost"),

                new Songs(   "S7",
              "Sacred",
             "3",
              "Bill Kaulitz, Roth, Benzner, Jost",
             "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "S8",
             "Break Away",
              "3",
              "Bill Kaulitz, Roth, Benzner, Jost, Hoffmann",
              "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "S9",
             "Rescue Me",
              "3",
              "Bill Kaulitz, Roth, Benzner, Jost, Hoffmann",
             "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(
              "S10",
              "Final Day",
             "3",
              "Bill Kaulitz, Roth, Benzner, Jost, Hoffmann",
              "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "S11",
              "Forgotten Children",
              "3",
              "Roth, Benzner, Jost, Bill Kaulitz",
              "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "S12",
              "By Your Side",
             "3",
             "Bill Kaulitz, Roth, Benzner, Jost, Hoffmann",
             "Peter Hoffmann, Patrick Benzner, Roth, Jost"),

            };
        }
        public static ObservableCollection<Songs> Album4Songs()
        {


            return new ObservableCollection<Songs>()
            {

                new Songs(  "H1",
              "Komm",
             "Noise",
             "4",
             "Bill Kaulitz, Roth, Benzner, Jost, Hoffmann",
             "Tom Kaulitz (co),Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "H2",
             "Sonnensystem",
              "Dark Side Of The Sun",
              "4",
             "Bill Kaulitz, Roth, Benzner, Jost",
              "Tom Kaulitz (co),Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "H3",
              "Automatisch",
              "Automatic",
              "4",
              "Roth, Benzner, Jost",
              "Tom Kaulitz (co),Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "H4",
              "Lass Uns Laufen",
              "World Behind My Wall",
              "4",
              "Roth, Benzner, Jost",
             "Tom Kaulitz (co),Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "H5",
              "Humanoid",
              "Humanoid",
              "4",
             "Roth, Benzner, Jost",
              "Tom Kaulitz (co),Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "H6",
              "Für immer jetzt",
              "Forever Now",
              "4",
              "Bill Kaulitz, Roth, Benzner, Jost",
              "Tom Kaulitz (co),Peter Hoffmann, Patrick Benzner, Roth, Jost"),

                new Songs(   "H7",
             "Kampf Der Liebe",
             "Pain Of Love",
             "4",
              "Roth, Benzner, Jost, Tokio Hotel",
             "Tom Kaulitz (co),Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "H8",
              "Hunde",
             "Dogs Unleashed",
             "4",
              "Tokio Hotel, Roth, Benzner, Jost",
              "Tom Kaulitz (co),Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "H9",
              "Menschen Suchen Menschen",
              "Human Connect To Human",
              "4",
              "Tokio Hotel, Roth, Jost",
              "Tom Kaulitz (co),Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(
              "H10",
              "Alien",
              "Alien",
              "4",
              "Roth, Benzner, Jost, Bill Kaulitz",
             "Tom Kaulitz (co),Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "H11",
              "Geisterfahrer",
             "Phantomrider",
              "4",
              "Tokio Hotel",
             "Tom Kaulitz (co),Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "H12",
              "Zoom",
              "Zoom Into Me",
              "4",
             "Tom Kaulitz (co),Bill Kaulitz, Desmond Child, Peter Hoffmann, Patrick Benzner, Roth, Jost"),

            };
        }
        public static ObservableCollection<Songs> Album5Songs()
        {


            return new ObservableCollection<Songs>()
            {
                 new Songs("K1",
              "Feel It All",
              "5",
              "Bill Kaulitz, Roth, Benzner, Jost, Hoffmann",
              "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "K2",
              "Stormy Weather",
              "5",
              "Bill Kaulitz, Roth, Benzner, Jost, Hoffmann",
             "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "K3",
              "Run, Run, Run",
              "5",
              "Bill Kaulitz, Roth, Benzner, Jost",
             "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "K4",
              "Love Who Loves You Back",
              "5",
              "Roth, Benzner, Jost",
             "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "K5",
              "Covered In Gold",
              "5",
              "Roth, Benzner, Jost",
              "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "K6",
              "Girl Got A Gun",
              "5",
              "Roth, Benzner, Jost",
              "Peter Hoffmann, Patrick Benzner, Roth, Jost"),

                new Songs( "K7",
             "Kings Of Suburbia",
              "5",
              "Bill Kaulitz, Roth, Benzner, Jost",
             "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "K8",
             "We Found Us",
              "5",
              "Roth, Benzner, Jost, Tokio Hotel",
              "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "K9",
              "Invaded",
              "5",
              "Tokio Hotel, Roth, Benzner, Jost",
              "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(
              "K10",
              "Never Let You Down",
              "5",
             "Tokio Hotel, Roth, Jost",
              "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "K11",
             "Louder Than Love",
              "5",
              "Roth, Benzner, Jost, Bill Kaulitz",
              "Peter Hoffmann, Patrick Benzner, Roth, Jost"),

            };
        }
        public static ObservableCollection<Songs> Album6Songs()
        {


            return new ObservableCollection<Songs>()
            {

                new Songs( "DM1",
              "Something New",
             "6",
            "Bill Kaulitz, Tom Kaulitz",
              "Bill Kaulitz, Tom Kaulitz, Devon Culiner"),
                new Songs( "DM2",
              "Boy Don't Cry",
              "6",
              "Bill Kaulitz, Tom Kaulitz",
              "Bill Kaulitz, Tom Kaulitz, Devon Culiner"),
                new Songs( "DM3",
              "Easy",
              "6",
              "Bill Kaulitz, Tom Kaulitz",
              "Bill Kaulitz, Tom Kaulitz, Devon Culiner"),
                new Songs(  "DM4",
              "What If",
              "6",
             "Bill Kaulitz, Tom Kaulitz",
              "Bill Kaulitz, Tom Kaulitz, Devon Culiner"),
                new Songs( "DM5",
              "Elysa",
              "6",
              "Bill Kaulitz, Tom Kaulitz, Nisse",
              "Bill Kaulitz, Tom Kaulitz, Devon Culiner"),
                new Songs(  "DM6",
              "Dream Machine",
             "6",
            "Bill Kaulitz, Tom Kaulitz",
              "Bill Kaulitz, Tom Kaulitz, Devon Culiner"),

                new Songs( "DM7",
             "Cotton Candy Sky",
              "6",
             "Bill Kaulitz, Tom Kaulitz",
              "Bill Kaulitz, Tom Kaulitz, Devon Culiner"),
                new Songs("DM8",
              "Better",
              "6",
              "Bill Kaulitz, Tom Kaulitz",
             "Bill Kaulitz, Tom Kaulitz, Devon Culiner"),
                new Songs( "DM9",
              "As Young As We Are",
            "6",
              "Bill Kaulitz, Tom Kaulitz, Shiro Gutzie",
              "Shiro Gutzie"),
                new Songs(
              "DM10",
             "Stop, Babe",
              "6",
             "Bill Kaulitz, Tom Kaulitz",
             "Bill Kaulitz, Tom Kaulitz, Devon Culiner"),

            };
        }
        public static ObservableCollection<Songs> AllSongs()
        {


            return new ObservableCollection<Songs>()
            {

                new Songs( "Sch1",
                            "Schrei",
                             "1","David Jost, Dave Roth",
                            "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "Sch2",
                            "Durch den Monsun",
                            "1",
                            "Bill Kaulitz, Roth, Benzner, Jost, Hoffmann",
                            "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "Sch3",
                             "Leb die Sekunde",
                             "1",
                             "Bill Kaulitz, Roth, Benzner, Jost",
                             "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "Sch4",
                            "Rette Mich",
                            "1",
                             "Roth, Benzner, Jost",
                            "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "Sch5",
                               "Freunde Bleiben",
                                "1",
                                "Roth, Benzner, Jost",
                                "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "Sch6",
                                "Ich bin nich'ich",
                                 "1",
                                 "Roth, Benzner, Jost",
                                 "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "Sch7",
                                "Wenn nichts mehr geht",
                                 "1",
                                "Bill Kaulitz, Roth, Benzner, Jost",
                                 "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "Sch8",
                             "Laß uns hier raus",
                              "1",
                               "Roth, Benzner, Jost, Tokio Hotel",
                                "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                 new Songs(  "Sch9",
                                 "Gegen meinen Willen",
                                "1",
                                 "Tokio Hotel, Roth, Benzner, Jost",
                                "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                  new Songs(  "Sch10",
                                "Jung und nicht mehr jugendfrei",
                                "1",
                                 "Tokio Hotel, Roth, Jost",
                                 "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                   new Songs(  "Sch11",
                                 "Der letzte Tag",
                                "1",
                                  "Roth, Benzner, Jost, Bill Kaulitz",
                                  "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                    new Songs(  "Sch12",
                                    "Unendlichkeit",
                                    "1",
                                    "Tokio Hotel",
                                     "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                     new Songs(  "Sch13",
                                    "Monsun o Koete",
                                     "1",
                                     "Tokio Hotel",
                                     "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                      new Songs( "Z1",
                             "Übers Ende der Wel",
                                "2",
                                "David Jost, Dave Roth, Patrick Benzner, Peter Hoffmann, Bill Kaulitz, Tom Kaulitz",
                                "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "Z2",
                             "Totgeliebt",
                             "2",
                                "Bill Kaulitz, Tom Kaulitz, Georg Listing, Gustav Schafer, Roth, Benzner, Jost, Hoffmann",
                                "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "Z3",
                            "Spring Nicht",
                             "2",
                             "Bill Kaulitz, Tom Kaulitz, Roth, Benzner, Jost, Hoffmann",
                             "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "Z4",
                            "Heilig",
                            "2",
                             "Roth, Benzner, Jost, Hoffmann, Bill Kaulitz",
                               "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "Z5",
                             "Wo sind eure Hände",
                                "2",
                                "Roth, Benzner, Jost, Hoffmann, Bill Kaulitz, Tom Kaulitz, Gustav Schafer, Georg Listing ",
                                "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "Z6",
                                "Stich ins Glück",
                                 "2",
                                "Roth, Benzner, Jost, Hoffmann, Bill Kaulitz, Tom Kaulitz",
                                "Peter Hoffmann, Patrick Benzner, Roth, Jost"),

                new Songs(  "Z7",
                             "Ich brech aus",
                            "2",
                            "Roth, Benzner, Jost, Hoffmann, Bill Kaulitz, Tom Kaulitz, Georg Listing, Gustav Schafer",
                            "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "Z8",
                            "Reden",
                             "2",
                            "Bill Kaulitz, Roth, Benzner, Jost, Hoffmann, Bill Kaulitz, Tom Kaulitz",
                            "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "Z9",
                             "Nach Dir Kommt Nichts",
                              "2",
                                "Roth, Benzner, Jost, Hoffmann, Tom Kaulitz, Bill Kaulitz",
                                "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "Z10",
                               "Wir Sterben Niemals Aus",
                                "2",
                                 "Bill Kaulitz, Tom Kaulitz",
                                "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "Z11",
                            "Vergessene Kinder",
                            "2",
                            "Roth, Benzner, Jost, Hoffmann, Bill Kaulitz, Tom Kaulitz",
                             "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "Z12",
                            "An Deiner Seite",
                             "2",
                            "Roth, Benzner, Jost, Hoffmann, Bill Kaulitz",
                            "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "Z13",
                            "In Die Nacht",
                             "2",
                             "Bill Kaulitz",
                            "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                 new Songs( "S1",
             "Scream",
            "3",
             "Bill Kaulitz, Roth, Benzner, Jost, Hoffmann",
             "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "S2",
              "Ready, Set, Go",
             "3",
              "Bill Kaulitz, Roth, Benzner, Jost, Hoffmann",
              "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "S3",
              "Monsoon",
             "3",
             "Bill Kaulitz, Roth, Benzner, Jost",
              "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "S4",
             "Love Is Dead",
              "3",
              "Bill Kaulitz, Roth, Benzner, Jost, Hoffmann",
             "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "S5",
             "Don't Jump",
              "3",
             "Bill Kaulitz, Roth, Benzner, Jost, Hoffmann",
              "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "S6",
             "On The Edge",
              "3",
              "Bill Kaulitz, Roth, Benzner, Jost, Hoffmann",
              "Peter Hoffmann, Patrick Benzner, Roth, Jost"),

                new Songs(   "S7",
              "Sacred",
             "3",
              "Bill Kaulitz, Roth, Benzner, Jost",
             "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "S8",
             "Break Away",
              "3",
              "Bill Kaulitz, Roth, Benzner, Jost, Hoffmann",
              "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "S9",
             "Rescue Me",
              "3",
              "Bill Kaulitz, Roth, Benzner, Jost, Hoffmann",
             "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(
              "S10",
              "Final Day",
             "3",
              "Bill Kaulitz, Roth, Benzner, Jost, Hoffmann",
              "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "S11",
              "Forgotten Children",
              "3",
              "Roth, Benzner, Jost, Bill Kaulitz",
              "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "S12",
              "By Your Side",
             "3",
             "Bill Kaulitz, Roth, Benzner, Jost, Hoffmann",
             "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                 new Songs(  "H1",
              "Komm",
             "Noise",
             "4",
             "Bill Kaulitz, Roth, Benzner, Jost, Hoffmann",
             "Tom Kaulitz (co),Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "H2",
             "Sonnensystem",
              "Dark Side Of The Sun",
              "4",
             "Bill Kaulitz, Roth, Benzner, Jost",
              "Tom Kaulitz (co),Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "H3",
              "Automatisch",
              "Automatic",
              "4",
              "Roth, Benzner, Jost",
              "Tom Kaulitz (co),Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "H4",
              "Lass Uns Laufen",
              "World Behind My Wall",
              "4",
              "Roth, Benzner, Jost",
             "Tom Kaulitz (co),Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "H5",
              "Humanoid",
              "Humanoid",
              "4",
             "Roth, Benzner, Jost",
              "Tom Kaulitz (co),Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "H6",
              "Für immer jetzt",
              "Forever Now",
              "4",
              "Bill Kaulitz, Roth, Benzner, Jost",
              "Tom Kaulitz (co),Peter Hoffmann, Patrick Benzner, Roth, Jost"),

                new Songs(   "H7",
             "Kampf Der Liebe",
             "Pain Of Love",
             "4",
              "Roth, Benzner, Jost, Tokio Hotel",
             "Tom Kaulitz (co),Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "H8",
              "Hunde",
             "Dogs Unleashed",
             "4",
              "Tokio Hotel, Roth, Benzner, Jost",
              "Tom Kaulitz (co),Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "H9",
              "Menschen Suchen Menschen",
              "Human Connect To Human",
              "4",
              "Tokio Hotel, Roth, Jost",
              "Tom Kaulitz (co),Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(
              "H10",
              "Alien",
              "Alien",
              "4",
              "Roth, Benzner, Jost, Bill Kaulitz",
             "Tom Kaulitz (co),Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "H11",
              "Geisterfahrer",
             "Phantomrider",
              "4",
              "Tokio Hotel",
             "Tom Kaulitz (co),Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "H12",
              "Zoom",
              "Zoom Into Me",
              "4",
             "Tom Kaulitz (co),Bill Kaulitz, Desmond Child, Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                  new Songs("K1",
              "Feel It All",
              "5",
              "Bill Kaulitz, Roth, Benzner, Jost, Hoffmann",
              "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "K2",
              "Stormy Weather",
              "5",
              "Bill Kaulitz, Roth, Benzner, Jost, Hoffmann",
             "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "K3",
              "Run, Run, Run",
              "5",
              "Bill Kaulitz, Roth, Benzner, Jost",
             "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "K4",
              "Love Who Loves You Back",
              "5",
              "Roth, Benzner, Jost",
             "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "K5",
              "Covered In Gold",
              "5",
              "Roth, Benzner, Jost",
              "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "K6",
              "Girl Got A Gun",
              "5",
              "Roth, Benzner, Jost",
              "Peter Hoffmann, Patrick Benzner, Roth, Jost"),

                new Songs( "K7",
             "Kings Of Suburbia",
              "5",
              "Bill Kaulitz, Roth, Benzner, Jost",
             "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs( "K8",
             "We Found Us",
              "5",
              "Roth, Benzner, Jost, Tokio Hotel",
              "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "K9",
              "Invaded",
              "5",
              "Tokio Hotel, Roth, Benzner, Jost",
              "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(
              "K10",
              "Never Let You Down",
              "5",
             "Tokio Hotel, Roth, Jost",
              "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                new Songs(  "K11",
             "Louder Than Love",
              "5",
              "Roth, Benzner, Jost, Bill Kaulitz",
              "Peter Hoffmann, Patrick Benzner, Roth, Jost"),
                  new Songs( "DM1",
              "Something New",
             "6",
            "Bill Kaulitz, Tom Kaulitz",
              "Bill Kaulitz, Tom Kaulitz, Devon Culiner"),
                new Songs( "DM2",
              "Boy Don't Cry",
              "6",
              "Bill Kaulitz, Tom Kaulitz",
              "Bill Kaulitz, Tom Kaulitz, Devon Culiner"),
                new Songs( "DM3",
              "Easy",
              "6",
              "Bill Kaulitz, Tom Kaulitz",
              "Bill Kaulitz, Tom Kaulitz, Devon Culiner"),
                new Songs(  "DM4",
              "What If",
              "6",
             "Bill Kaulitz, Tom Kaulitz",
              "Bill Kaulitz, Tom Kaulitz, Devon Culiner"),
                new Songs( "DM5",
              "Elysa",
              "6",
              "Bill Kaulitz, Tom Kaulitz, Nisse",
              "Bill Kaulitz, Tom Kaulitz, Devon Culiner"),
                new Songs(  "DM6",
              "Dream Machine",
             "6",
            "Bill Kaulitz, Tom Kaulitz",
              "Bill Kaulitz, Tom Kaulitz, Devon Culiner"),

                new Songs( "DM7",
             "Cotton Candy Sky",
              "6",
             "Bill Kaulitz, Tom Kaulitz",
              "Bill Kaulitz, Tom Kaulitz, Devon Culiner"),
                new Songs("DM8",
              "Better",
              "6",
              "Bill Kaulitz, Tom Kaulitz",
             "Bill Kaulitz, Tom Kaulitz, Devon Culiner"),
                new Songs( "DM9",
              "As Young As We Are",
            "6",
              "Bill Kaulitz, Tom Kaulitz, Shiro Gutzie",
              "Shiro Gutzie"),
                new Songs(
              "DM10",
             "Stop, Babe",
              "6",
             "Bill Kaulitz, Tom Kaulitz",
             "Bill Kaulitz, Tom Kaulitz, Devon Culiner"),

            };
        }
    }
    
}
