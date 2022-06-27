using System;

namespace ClassLibraryJA
{
    public class Class1
    {
        static bool ReadBoolMethod(DateTime CompletionDate)
        {
            var estimatedPäivä = 5 * 8; // selvä
            var timespent = 10; // selvä
            var tarvittava = estimatedPäivä - timespent; // selvä
            var jäljellä = 8; // completiondate - datetime.now välissä

            DateTime aloitusdate = new DateTime();

            DateTime testi = new DateTime();

            var completionDate = aloitusdate.AddHours(timespent);

            
            var Tulos = tarvittava < jäljellä;


            return (CompletionDate.Date > DateTime.UtcNow.Date);

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