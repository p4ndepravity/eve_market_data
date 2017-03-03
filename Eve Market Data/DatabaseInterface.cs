using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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

        public void UpdateType(int typeIdInGame, double newMargin, string newName = null)
        {
            using (var db = new TypeContext())
            {
                var result = db.Types.SingleOrDefault(t => t.TypeIdInGame == typeIdInGame);
                if (result != null)
                {
                    if (newName != null) result.TypeName = newName;
                    result.TypeMargin = newMargin;
                    db.SaveChanges();
                }
            }
        }

        private void InsertType(Type type)
        {
            using (var db = new TypeContext())
            {
                db.Types.Add(type);
                db.SaveChanges();
            }
        }
    }
}
