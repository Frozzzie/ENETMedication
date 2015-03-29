using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENETClasses.EntityInteraction
{
    interface ISQLTable
    {
        // When an object is represented in the database, it should have this interface tagged onto it.

        // Will eventually carry a method on it:
        // void ReadFromSQL(SQLStream reader);
        // void WriteToSQL(SQLStream writer);
        
        // so that we can save and write it to the database.
        
        // *********************************************\\
        // However, it might also be worthwhile to simply not have these functions in, and instead create
        // a SQLSerializer object that takes ISQLTable objects and writes/loads these objects
        // using reflection. When it comes to doing it I'll talk to you guys before I do either
        // - Shane
    }
}
