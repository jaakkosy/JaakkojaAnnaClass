using System;

namespace ClassLibraryJA
{
    public class Aikataulussa
    {
        public bool ReadBoolMethod(float estimatedPaiva, float timeSpent)
        {
           
            float tarvittava = estimatedPaiva - timeSpent; // selvä (34h)

            float jäljellä = 1*8; // completiondate - datetime.now välissä

            /*DateTime aloitusdate = new DateTime();

            DateTime testi = new DateTime();

            var completionDate = aloitusdate.AddHours(timespent);*/



            bool Tulos = tarvittava < jäljellä;
            return Tulos;


            //return (CompletionDate.Date > DateTime.UtcNow.Date);

        }

        public bool ReadBoolMethod2(DateTime? CompletionDate)
        {

            return (CompletionDate > DateTime.UtcNow.Date);

        }

    }


}

// TESTIMUUTOS ANNALTA

// 8hour / pv
// 


//5 pv, 8 h / pv = 40h / viikko. 

//4. pv kohdalla Timespent = 5h.

//    estimated - timespent = 


//



// var montakoOpiskeluPäivääJäljellä = (estimated(40h) - timespent(10h)) / 8h 
// boolTulos = montakoOpiskeluPäivääJäljellä > jotain 