﻿namespace OOP_lab_5_7_1
{
    class Reception : Doctor
    {
        private string _day;
        private string _shift;
        private int _visitorsCount;

        public string Day
        {
            get => _day;
            set => _day = value;
        }

        public string Shift
        {
            get => _shift;
            set => _shift = value;
        }

        public int VisitorsCount
        {
            get => _visitorsCount;
            set => _visitorsCount = value;
        }

        public Reception()
        {
            Surename = "Не вказано.";
            Profession = "Не вказано.";
            Day = "Не вказано.";
            Shift = "Не вказано.";
            VisitorsCount = 0;
        }
        public Reception(string surename, string profession, string day, string shift, int visitorsCount)
        {
            Surename = surename;
            Profession = profession;
            Day = day;
            Shift = shift;
            VisitorsCount = visitorsCount;
        }
    }
}