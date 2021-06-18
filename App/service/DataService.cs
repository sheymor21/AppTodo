using System;
using System.Collections.Generic;
using System.Linq;
using Database;
using Microsoft.AspNetCore.Mvc;

namespace Services
{

    public class NoteService
    {
        private readonly NotasContext db = new NotasContext();
        public void addNotes(Notas nota)
        {
            db.Add(new Notas
            {
                Contenido = nota.Contenido,
                fecha = DateTime.Now,
                completada = nota.completada
            });
            db.SaveChanges();
        }

        public List<Notas> getNotes()
        {
            return db.notes.OrderBy(b => b.NotasId).ToList();
        }

        public void removeNotes(int id)
        {
            foreach (var item in db.notes.OrderBy(b=>b.NotasId).ToList())
            {
                if(item.NotasId == id)
                {
                    db.Remove(item);
                }
            }
            db.SaveChanges();
        }

        public void getEditNotes(Notas nota)
        {
            foreach (var item in db.notes.OrderBy(b => b.NotasId).ToList())
            {
                if (item.NotasId == nota.NotasId)
                {
                    item.Contenido = nota.Contenido;
                    item.fecha = DateTime.Now;
                    item.completada = nota.completada;
                }
            }
            db.SaveChanges();
        }

    }
}