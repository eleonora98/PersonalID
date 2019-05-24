using System;

namespace PersonalID
{
    class ValidationID
    {

        public static bool ValidateID(string id, out int idYear, out int idMonth, out int idDay, out int idGender)
        {

            idYear = Convert.ToInt32(id.Substring(0, 2));
            idMonth = Convert.ToInt32(id.Substring(2, 2));
            idDay = Convert.ToInt32(id.Substring(4, 2));
            idGender = Convert.ToInt32(id.Substring(8, 1));

            int idFirst = Convert.ToInt32(id.Substring(0, 1));
            int idSecond = Convert.ToInt32(id.Substring(1, 1));
            int idThird = Convert.ToInt32(id.Substring(2, 1));
            int idFourth = Convert.ToInt32(id.Substring(3, 1));
            int idFifth = Convert.ToInt32(id.Substring(4, 1));
            int idSixth = Convert.ToInt32(id.Substring(5, 1));
            int idSeventh = Convert.ToInt32(id.Substring(6, 1));
            int idEight = Convert.ToInt32(id.Substring(7, 1));
            int idNinth = Convert.ToInt32(id.Substring(8, 1));
            int idTenth = Convert.ToInt32(id.Substring(9, 1));

            int control = (idFirst * 2 + idSecond * 4 + idThird * 8 + idFourth * 5 + idFifth * 10 + idSixth * 9 + idSeventh * 7 + idEight * 3 + idNinth * 6) % 11; //A variable that is used for the algorithm about the tenth digit of the ID number that stands for control

            if (id.Length == 10 && idMonth != 0 && idDay > 0 && idDay < 32 && ((idMonth >= 1 && idMonth <= 12) || (idMonth >= 21 && idMonth <= 32) || (idMonth >= 41 && idMonth <= 52)) && ((control < 10 && control == idTenth) || (control == 10 && idTenth == 0)))
            {
                if (idMonth >= 1 && idMonth <= 12)
                {
                    Console.WriteLine("Birthdate: 19{0}.{1}.{2}", idYear, idMonth, idDay);
                }
                else if (idMonth >= 21 && idMonth <= 32)
                {
                    idMonth = idMonth - 20;
                    Console.WriteLine("Birthdate: 18{0}.{1}.{2}", idYear, idMonth, idDay);
                }
                else if (idMonth >= 41 && idMonth <= 52)
                {
                    idMonth = idMonth - 40;
                    Console.WriteLine("Birthdate: 20{0}.{1}.{2}", idYear, idMonth, idDay);
                }
                if (idGender % 2 == 0) //if the digit which stands for the sex of the person (the ninth digit) is an even number, then it is Male
                {
                    Console.WriteLine(Gender.Male);

                }
                else if (idGender % 2 != 0) //if the digit which stands for the sex of the person (the ninth digit) is an odd number, then it is Female
                {
                    Console.WriteLine(Gender.Female);
                }


                return true;
            }
            else
            {

                return false;
            }
        }


    }
}
