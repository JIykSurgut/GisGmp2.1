using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GisGmp.DIT._1
{
    class Poligon
    {
        SmevEndpointFacadeWsClient client = new SmevEndpointFacadeWsClient();

        public Poligon()
        {
            client.SendRequest(
                //Обертка СМЭВ
                new sendRequestRequest()
                {
                    //Код точки доступа к СМЭВ 3.0;
                    EndpointCode = "?",

                    //Код системы назначения для отправки ответа
                    EndSystemCode = "?",

                    //в тестовом контуре СМЭВ 3.0 возвращается по эталонному запросу эталонный ответ;
                    //IsTest = true,
                    //IsTestSpecified

                    //СМЭВ 3 и код транзакции – генерируется операцией GenerateMark этого же сервиса
                    //TransactionCode

                    //СМЭВ 3 и MessageId первоначального запроса
                    //ReferenceMessageId

                    //СМЭВ 3 и время жизни запроса
                    //EOL
                    //EOLSpecified

                    //
                    //Data = new data() { Any = }

                    //Attachment

                    //PersonalSignature

                    //TransactionCode
                }) ;
        
        }

    }
}
