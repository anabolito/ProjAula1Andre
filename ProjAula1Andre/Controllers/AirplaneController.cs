using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjAula1Andre.Services;
using ProjAula1Andre.Models;

namespace ProjAula1Andre.Controllers
{
    public class AirplaneController
    {
        public bool Insert(Airplane airplane)
        {
            return new AirplaneService().Insert(airplane);
        }
        public List<Airplane> FindAll()
        {

            return new AirplaneService().FindAll();
        }
    }
}
