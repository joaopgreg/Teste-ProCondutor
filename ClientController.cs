using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteProCondutor.Context;
using TesteProCondutor.DAO;
using TesteProCondutor.Model;

namespace TesteProCondutor.Controllers
{
    public class ClientController : Controller
    {
        ClientDbContext db;

        public ClientController()
        {
            db = new ClientDbContext();
        }


        public ActionResult Index()
        {
            var Clients = db.Clientes.OrderByDescending(x => x.ClientId);
            return View(Clients);
        }

        public ActionResult Details(int id)
        {
            var Clients = db.Clientes.FirstOrDefault(x => x.ClientId == id);

            ClientViewModel model = new ClientViewModel()
            {
                ClientId = Clients.ClientId,
                NomeCompleto = Clients.NomeCompleto,
                DataDeNascimento = Clients.DataDeNascimento,
                CPF = Clients.CPF,
                Celular = Clients.Celular,
                Telefone = Clients.Telefone,
                Bairro = Clients.Bairro,
                Cidade = Clients.cidade,
                EnderecoNumero = Clients.EnderecoNumero,
                Complemento = Clients.Complemento,
                Contato = Clients.Contato,
                Endereco = Clients.Endereco,
                Estado = Clients.Estado
            };

            return View(model);
        }

        public ActionResult Create()
        {
            ClientViewModel model = new ClientViewModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClientViewModel model)
        {
            try
            {
                Client client = new Client()
                {
                    NomeCompleto = model.NomeCompleto,
                    DataDeNascimento = model.DataDeNascimento,
                    CPF = model.CPF,
                    Endereco = model.Endereco,
                    EnderecoNumero = model.EnderecoNumero,
                    Bairro = model.Bairro,
                    cidade = model.Cidade,
                    Complemento = model.Complemento,
                    Celular = model.Cidade,
                    Telefone = model.Telefone,
                    Contato = model.Contato,
                    Estado = model.Estado

                };

                db.Clientes.Add(client);
                db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            var Clients = db.Clientes.FirstOrDefault(x => x.ClientId == id);

            ClientViewModel model = new ClientViewModel()
            {
                ClientId = Clients.ClientId,
                NomeCompleto = Clients.NomeCompleto,
                DataDeNascimento = Clients.DataDeNascimento,
                CPF = Clients.CPF,
                Celular = Clients.Celular,
                Telefone = Clients.Telefone,
                Bairro = Clients.Bairro,
                Cidade = Clients.cidade,
                EnderecoNumero = Clients.EnderecoNumero,
                Complemento = Clients.Complemento,
                Contato = Clients.Contato,
                Endereco = Clients.Endereco,
                Estado = Clients.Estado
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ClientViewModel model)
        {
            try
            {
                var Clients = db.Clientes.FirstOrDefault(x => x.ClientId == id);

                Clients.NomeCompleto = model.NomeCompleto;
                Clients.CPF = model.CPF;
                Clients.DataDeNascimento = model.DataDeNascimento;
                Clients.Contato = model.Contato;
                Clients.Telefone = model.Telefone;
                Clients.Celular = model.Celular;
                Clients.Endereco = model.Endereco;
                Clients.EnderecoNumero = model.EnderecoNumero;
                Clients.Complemento = model.Complemento;
                Clients.Bairro = model.Bairro;
                Clients.cidade = model.Cidade;
                Clients.Estado = model.Estado;

                this.db.Entry(Clients).CurrentValues.SetValues(Clients);
                db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            var Clients = db.Clientes.FirstOrDefault(x => x.ClientId == id);

            ClientViewModel model = new ClientViewModel()
            {
                ClientId = Clients.ClientId,
                NomeCompleto = Clients.NomeCompleto,
                DataDeNascimento = Clients.DataDeNascimento,
                CPF = Clients.CPF,
                Celular = Clients.Celular,
                Telefone = Clients.Telefone,
                Bairro = Clients.Bairro,
                Cidade = Clients.cidade,
                EnderecoNumero = Clients.EnderecoNumero,
                Complemento = Clients.Complemento,
                Contato = Clients.Contato,
                Endereco = Clients.Endereco,
                Estado = Clients.Estado
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult _Delete(int id)
        {
            try
            {
                var Clients = db.Clientes.FirstOrDefault(x => x.ClientId == id);
                db.Clientes.Remove(Clients);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
