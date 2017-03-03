using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;

namespace Eve_Market_Data
{
    class DatabaseInterface
    {
        public BindingList<Type> GetTypeContextBindingList()
        {
            using (var db = new TypeContext())
            {
                return db.Types.Local.ToBindingList();
            }
        }

        public void Add(object thing)
        {
            List<object> objects = new List<object>();
            objects.Add(thing);
            if (objects.OfType<Type>() != null) InsertType((Type)thing);
        }

        public void UpdateType(int typeIdInGame, double newMargin, string newName = null)
        {
            Type type;
            using (var db = new TypeContext())
            {
                type = db.Types.Where(t => t.TypeIdInGame == typeIdInGame).FirstOrDefault();
            }

            if (type != null)
            {
                type.TypeMargin = newMargin;
                if (newName != null) type.TypeName = newName;
            }

            using (var db2 = new TypeContext())
            {
                db2.Entry(type).State = EntityState.Modified;
                db2.SaveChanges();
                //db2.Types.Load();
            }
        }

        internal void ReloadTypeContext()
        {
            using (var db = new TypeContext())
            {
                db.Types.Load();
            }
        }

        private void InsertType(Type type)
        {
            using (var db = new TypeContext())
            {
                db.Types.Add(type);
                db.SaveChanges();
                //db.Types.Load();
            }
        }

        internal object GetTypeObject(int tempId)
        {
            Type tempType;
            using (var db = new TypeContext())
            {
                tempType = db.Types.Where(t => t.TypeIdInGame == tempId).FirstOrDefault();
            }
            return tempType;
        }
    }
}
