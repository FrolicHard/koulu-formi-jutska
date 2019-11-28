using System;
using System.Collections.Generic;
using Autokauppa.model;


namespace Autokauppa.controller
{


    public class AutoRegisterHandler
    {
        DatabaseController dbController = new DatabaseController();

        public bool TestDatabaseConnection()
        {
            bool doesItWork = dbController.ConnectDatabase();
            return doesItWork;
        }

        public bool SaveAuto(Auto newAuto)
        {
            bool didItGoIntoDatabase = dbController.SaveAutoIntoDatabase(newAuto);
            return didItGoIntoDatabase;
        }

        public List<AutonMerkki> GetAllAutoMakers() {

            return dbController.GetAllAutoMakersFromDatabase();
        }

        public List<AutonMalli> GetAutoModels(int makerId) {

            return dbController.GetAutoModelsByMakerId(makerId);
        }
        public List<Polttoaine> GetFuels()
        {
            return dbController.GetAllFuelsFromDatabase();
        }
        public List<Vari> GetVarit()
        {
            return dbController.GetColorsFromDatabase();
        }
        public int DeleteSelectedRowFromDatabase(int selectedID)
        {
            return dbController.DeleteRowFromDatabase(selectedID);
        }

        public Auto ValitseEdellinen(int selectedID)
        {
            Auto tuotu = dbController.SelectPreviousAutoRow(selectedID);
            if (tuotu != null)
            {
                return tuotu;
            }
            else
            {
                tuotu = dbController.ChooseAutoMax();
                if (tuotu != null)
                {
                    return tuotu;
                }
                else
                {
                    Console.WriteLine("Auton valinta epäonnistui!");
                    return null;
                }
            }
        }

        public Auto ValitseSeuraava(int selectedID)
        {
            Auto tuotu = dbController.SelectNextAutoRow(selectedID);
            if (tuotu != null)
            {
                return tuotu;
            }
            else
            {
                tuotu = dbController.ChooseAutoMin();
                if (tuotu != null)
                {
                    return tuotu;
                }
                else
                {
                    Console.WriteLine("Auton valinta epäonnistui!");
                    return null;                  
                }
            }
        }
    }
}
