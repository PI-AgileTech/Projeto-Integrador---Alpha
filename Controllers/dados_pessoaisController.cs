using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Alpha.Models;

namespace Alpha.Controllers
{
    public class dados_pessoaisController : Controller
    {
        private Entities db = new Entities();

        // GET: dados_pessoais
        public ActionResult Index()
        {
            return View(db.dados_pessoaisSet.ToList());
        }

        // GET: dados_pessoais/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dados_pessoais dados_pessoais = db.dados_pessoaisSet.Find(id);
            if (dados_pessoais == null)
            {
                return HttpNotFound();
            }
            return View(dados_pessoais);
        }

        // GET: dados_pessoais/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: dados_pessoais/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "dados_pessoais_Id,nome,data_nascimento,cpf,sexo,telefone,email,rua,numero,bairro,cep,uf,status_relacionamento")] dados_pessoais dados_pessoais)
        {
            if (ModelState.IsValid)
            {
                db.dados_pessoaisSet.Add(dados_pessoais);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dados_pessoais);
        }

        // GET: dados_pessoais/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dados_pessoais dados_pessoais = db.dados_pessoaisSet.Find(id);
            if (dados_pessoais == null)
            {
                return HttpNotFound();
            }
            return View(dados_pessoais);
        }

        // POST: dados_pessoais/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "dados_pessoais_Id,nome,data_nascimento,cpf,sexo,telefone,email,rua,numero,bairro,cep,uf,status_relacionamento")] dados_pessoais dados_pessoais)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dados_pessoais).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dados_pessoais);
        }

        // GET: dados_pessoais/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dados_pessoais dados_pessoais = db.dados_pessoaisSet.Find(id);
            if (dados_pessoais == null)
            {
                return HttpNotFound();
            }
            return View(dados_pessoais);
        }

        // POST: dados_pessoais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            dados_pessoais dados_pessoais = db.dados_pessoaisSet.Find(id);
            db.dados_pessoaisSet.Remove(dados_pessoais);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
