namespace OOP_lab_5_7_1
{
    class Doctor
    {
        private string _surename;
        private string _profession;

        public string Surename
        {
            get => _surename;
            set => _surename = value;
        }

        public string Profession
        {
            get => _profession;
            set => _profession = value;
        }

        public Doctor()
        {
            _surename = "Не вказано.";
            _profession = "Не вказано.";
        }

        public Doctor(string surename, string profession)
        {
            Surename = surename;
            Profession = profession;
        }
    }
}
