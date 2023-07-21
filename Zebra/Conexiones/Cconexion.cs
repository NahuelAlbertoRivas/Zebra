using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace Zebra.Conexiones
{
    public class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://zebra-78a10-default-rtdb.firebaseio.com/");
    }
}
