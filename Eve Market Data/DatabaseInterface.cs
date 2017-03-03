using System.Collections.Generic;
using System.Linq;

namespace Eve_Market_Data
{
    class DatabaseInterface
    {
        public void Add(object thing)
        {
            List<object> objects = new List<object>();
            objects.Add(thing);
            if (objects.OfType<Type>() != null) InsertType((Type)thing);
        }

        private void InsertType(Type type)
        {
            using (var db = new TypeContext())
            {
                db.Types.Add(type);
                db.SaveChanges();
            }
        }

        private void UpdateMargin(int typeId, double margin)
        {
            using (var db = new TypeContext())
            {
                //db.Types
            }
        }
    }
}
