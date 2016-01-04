namespace Egyptian_National_ID
{
    class IDAnalyst
    {
        /*
        To get the birth day 
        XXXXXNNXXXXXXX
        NN = birth day, so we will take it from the input number
         */
        public string GetBirthDay(long number)
        {
            string num = number.ToString();
            num = num.Substring(5, 2);
            return num;
        }
        /*
        To get the birth month 
        XXXMMXXXXXXXXX
        MM = birth day, so we will take it from the input number
         */
        public string GetBirthMonth(long number)
        {
            string num = number.ToString();
            num = num.Substring(3, 2);
            return num;
        }
        /*
        To get the birth year 
        CYYXXXXXXXXXXX
        YY = birth day, so we will take it from the input number
        and check C if it equal to 2 will be in 19th and else in 20th
         */
        public string GetBirthYear(long number)
        {
            string num = number.ToString();
            string cen = num.Substring(0, 1);
            num = num.Substring(1, 2);
            if (cen == "2")
                return "19" + num;
            else
                return "20" + num;
        }
        /*
        To get the province 
        XXXXXXXNNXXXXX
        NN = province number, so we will take it from the input number
        and check this number in cases and return the name of province
         */
        public string GetProvince(long number)
        {
            string num = number.ToString();
            int prov = int.Parse(num.Substring(7, 2));
            switch (prov)
            {

                case 01:
                    return "Cairo";

                case 02:
                    return "Alex";

                case 03:
                    return "PortSaid";

                case 04:
                    return "Swez";

                case 11:
                    return "Domyat";

                case 12:
                    return "Al-Daqahlya";

                case 13:
                    return "Ash Sharqya";

                case 14:
                    return "Qalyubya";

                case 15:
                    return "Kafr ElSheikh";

                case 16:
                    return "Gharbyah";

                case 17:
                    return "Monofya";

                case 18:
                    return "AlBehera";

                case 19:
                    return "Ismailia";

                case 21:
                    return "Giza";

                case 22:
                    return "Bani Swyf";

                case 23:
                    return "Fayoum";

                case 24:
                    return "Menya";

                case 25:
                    return "Assuit";

                case 26:
                    return "Sohag";

                case 27:
                    return "Qyna";

                case 28:
                    return "Aswan";

                case 29:
                    return "luxor";

                case 31:
                    return "Bahr Ahmar";

                case 32:
                    return "New Wady :D";

                case 33:
                    return "Matroh";

                case 34:
                    return "Shamal Synaa";

                case 35:
                    return "Janoub synaa";

                case 88:
                    return "Ouf Of Egypt";

                default:
                    return "Sorry We Can't find it";

            }

        }
        /*
        To get the province 
        XXXXXXXXXOOOOX
        OO = child number, so we will take it from the input number
         */
        public int NumOfChild(long number)
        {
            string num = number.ToString();
            num = num.Substring(9,4);
            int end = int.Parse(num);
            return end;
        }
        /*
        To get the Sex of Person 
        XXXXXXXXXXXXYX
        Y =  number, if this number was odd this mean he is male else female
         */
        public string Sex(long number)
        {
            string num = number.ToString();
            num = num.Substring(12, 1);
            int nu = int.Parse(num) % 2;
            if (nu == 0)
                return "Female";
            else
                return "Male";

        }
    }
}
